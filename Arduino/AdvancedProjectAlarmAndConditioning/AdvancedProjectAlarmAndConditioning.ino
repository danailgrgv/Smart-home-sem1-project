#include <dht11.h> // DHT library
#define DHT11PIN 4 // Initializes the DHT on pin 4
const int FANPIN = 3; // Initializes the fan on pin 3
const int BUZZER = 9; // Initializes the buzzer on pin 7

const int MOISTISH = 60; // A value for the moisture when the AC should turn on
const int TOOMOIST = 80; // A value for the moisture for whenm the smoke alarm should turn on
const int ALARM_LENGHT = 5000; // The lenght of the alarm
const int DELAY = 1000; // 1 second delay between the reading of the values

dht11 DHT11;
float temp; // A variable to store the temperature value in
float moist; // A variable to store the moisture value in
bool alarmState; // A boolean for the alarm (ON/OFF)
bool fanState; // A boolean for the fan (ON/OFF)
unsigned long startTime; // For the debounce
unsigned long buzzTime; // A variable for the buzzer delays
unsigned long millisDelay; // For the debounce
byte fanduty; // A variable for the fan intensity
void setup()
{
  Serial.begin(9600); // For the serial monitor
  pinMode(BUZZER, OUTPUT); // Sets the buzzer to output
  temp = 0; // Sets the temperature variable to 0
  moist = 0; // Sets the moisture variable to 0
  alarmState = false; // Sets the alarm to turned off
  fanState = false; // Sets the fan to turned off
  startTime = 0; // For the debounce
  buzzTime = 0; // Sets the buzz delay variable to 0
  millisDelay = 0; // For the debounce
  fanduty = 0;
}

void setFanSpeed(byte speed) // A method that sets the fan intensity
{
  // Determine the fan duty value.
  fanduty = map(speed, 0, 100, 0, 255);
  // Continues speed.
  analogWrite(FANPIN, fanduty);
}

void swingFan() // To be able to start the fan
{
  // Swing the fan.
  analogWrite(FANPIN, 255);
  delay(45);
  // Continues speed.
  analogWrite(FANPIN, fanduty);
}

void alarmBuzzer() // The alarm method
{
  noTone(BUZZER);
  if (millis() - buzzTime > 200) {
    tone(BUZZER, 2000);
    buzzTime = millis();
  }
}

void tempControl() // A method for the fan to work accordingly with the temperature
{
  if (temp >= 25)
  {
    if (fanState == false) // If turned off, the fan needs to be given a push with the swing function
    {
      fanduty = map(temp, 25, 30, 102, 255); // the temperature values we work with are between 25 and 30 degrees Celsius
      swingFan(); // Starts the fan
      fanState == true; // To indicate that the fan is on
    }
  }
  else if (temp < 23)
  {
    setFanSpeed(0);
    fanState == false;
  }
}

void loop()
{
  int chk = DHT11.read(DHT11PIN);
  moist = DHT11.humidity;
  if (millis() - millisDelay > DELAY) // Reads the temperature value provided bya the DHT every second
  {
    temp = DHT11.temperature;
    millisDelay = millis();
    //Serial.println(temp);
    //Serial.println(moist);
  }
  
  if (moist > MOISTISH) // Turns on the fan if the moisture in the air is high
  {
    if (fanState == false) // If turned off, the fan needs to be given a push with the swing function
    {
      setFanSpeed(50); // Sets the fan speed to 50%
      swingFan(); // Start the fan
      fanState == true; // To indicate that the fan is on
    }
    else // If the fan is already on, just set the speed
    {
      setFanSpeed(50); // Sets the fan speed to 50%
    }

    if (moist > TOOMOIST || alarmState == true) // Turns on the alarm if "smoke" is detected and the fan to max
    {

      setFanSpeed(100); // Turns the fan to max capacity
      swingFan();       //
      if (alarmState == false) // Checks of the alarm just started and saves the time
      {
        startTime = millis();
        Serial.println("AlarmOn");
      }
      alarmState = true; // To indicate that the alarm is on
      alarmBuzzer(); // The buzzer
      if (millis() - startTime > ALARM_LENGHT) // Checks if its time to turn off the alarm
      {
        noTone(BUZZER);
        alarmState = false; // Turns the alarm off
        Serial.println("AlarmOff");
      }
    }
  }
  else
  {
    tempControl(); // The temperature control
  }
}
