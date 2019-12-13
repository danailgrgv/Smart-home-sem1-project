#include <Servo.h>

// Pin constants
const int BUTTON_ADD = 2;
const int BUTTON_REMOVE = 4;
const int BUZZER = 7;
const int SERVO = 9;

// Other program constants
const int BUTTON_PRESS_THRESHOLD = 50;
const int RELOCK_TIME = 5000;
const int SERVO_UNLOCKED = 120;
const int SERVO_LOCKED = 30;

enum ButtonState {PRESSED, RELEASED, UNKNOWN};

unsigned long lastAddButtonTime = 0;
int lastAddButtonState = LOW;
unsigned long lastRemoveButtonTime = 0;
int lastRemoveButtonState = LOW;
unsigned long lastUnlockTime = 0;
bool lockOpen = false;

Servo servo;

void setup()
{
    // Begin serial communication and setup pin modes
    Serial.begin(9600);
    pinMode(SERVO, INPUT);
    pinMode(BUZZER, OUTPUT);
    pinMode(BUTTON_ADD, INPUT);
    pinMode(BUTTON_REMOVE, INPUT);

    // Setup servo
    servo.attach(SERVO);
    servo.write(SERVO_LOCKED);
}

void loop()
{
    // Check for commands from the C# application
    checkSerial();

    // Actuate the servomotor depending on door locking status
    actuateServo();

    // Read buttons and send appropriate signals to the C# application
    if (readDebouncedButton(BUTTON_ADD) == PRESSED)
    {
        Serial.println("ADD_KEY");
    }
    if (readDebouncedButton(BUTTON_REMOVE) == PRESSED)
    {
        Serial.println("REMOVE_KEY");
    }
}

void checkSerial()
{
    // Peek in the serial to see whether there are any outstanding commands
    if (Serial.peek() != -1)
    {
        // Read command and respond appropriately
        String command = Serial.readStringUntil('\n');
        if (command.indexOf("DENIED") > -1)
        {
            tone(BUZZER, 300, 500);
            lockOpen = false;
        }
        else if (command.indexOf("ALLOWED") > -1)
        {
            tone(BUZZER, 2000, 100);
            lockOpen = true;
        }
    }
}

void actuateServo()
{
    // Open or lock the door depending on the lockOpen variable
    if (lockOpen == true)
    {
        servo.write(SERVO_UNLOCKED);
        // Lock the door again after a few seconds have passed
        if (millis() - lastUnlockTime > RELOCK_TIME)
        {
            lockOpen = false;
        }
    }
    else
    {
        lastUnlockTime = millis();
        servo.write(SERVO_LOCKED);
    }
}

enum ButtonState readDebouncedButton(const int BUTTON)
{
    // Debounce button input and return a ButtonState value
    int buttonState = digitalRead(BUTTON);
    switch (BUTTON)
    {
    case BUTTON_ADD:
        if (buttonState != lastAddButtonState)
        {
            lastAddButtonState = buttonState;
            if ((millis() - lastAddButtonTime) > BUTTON_PRESS_THRESHOLD)
            {
                lastAddButtonTime = millis();
                if (buttonState == HIGH)
                {
                    return PRESSED;
                }
                return RELEASED;
            }
        }
        return UNKNOWN;

    case BUTTON_REMOVE:
        if (buttonState != lastRemoveButtonState)
        {
            lastRemoveButtonState = buttonState;
            if ((millis() - lastRemoveButtonTime) > BUTTON_PRESS_THRESHOLD)
            {
                lastRemoveButtonTime = millis();
                if (buttonState == HIGH)
                {
                    return PRESSED;
                }
                return RELEASED;
            }
        }
        return UNKNOWN;
    }
}
