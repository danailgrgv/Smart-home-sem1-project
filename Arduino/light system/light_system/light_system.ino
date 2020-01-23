#include "Ambitemp.h"
//#include <Display.h>

Ambitemp DHT;

enum ButtonState {PRESSED, RELEASED, UNKNOWN};

const int LDR = A5;
const int K1 = 4;
const int DHT11 = 7;
const int ADJUSTR = 9;
const int ADJUSTG = 10;
const int ADJUSTB = 11;
const int INTERVAL = 300;

int currentLightingMode = -1;
int lastButtonState = HIGH;
int valR, valG, valB;
unsigned long lastButtonTime = 0;
unsigned long currentInterval;
unsigned long lastTime;

String timeReceived;

void setup() {
  pinMode(LDR, INPUT);
  pinMode(K1, INPUT);
  pinMode(DHT11, INPUT);
  pinMode(ADJUSTR, OUTPUT);
  pinMode(ADJUSTG, OUTPUT);
  pinMode(ADJUSTB, OUTPUT);
  Serial.begin(9600);
  DHT.initialize(7);
  //Display.clear();
}

void loop() {
  enum ButtonState value;
  value = readDebouncedButton();
  if (value == PRESSED) { //1. Default 2. Party 3. Study 4. Meeting
    currentLightingMode++;
    if (currentLightingMode == 5) {
     currentLightingMode = 0;
    }
  }
  int ldrReading = analogRead(LDR);
  //Display.show(timeReceived.toFloat());
  switch (currentLightingMode) {
    case 0:
      if (timeReceived.toFloat() >= 7 && timeReceived.toFloat() <= 17) {
        if (ldrReading >= 800) {
          DefaultLightSwitch(0);
        }
        if (ldrReading >= 500 && ldrReading < 800) {
          DefaultLightSwitch(1);
        }
        if (ldrReading >= 500 && ldrReading < 800 && DHT.getHumidity() >= 80) {
          DefaultLightSwitch(2);
        }
      }
      else if (timeReceived.toFloat() > 17 && timeReceived.toFloat() <= 18.3) {
        DefaultLightSwitch(4);
      }
      else {
        DefaultLightSwitch(5);
      }
      break;
    case 1:
      DefaultLightSwitch(7);
      break;
    case 2:
      DefaultLightSwitch(8);
      break;
    case 3:
      DefaultLightSwitch(6);
      break;
    case 4:
      DefaultLightSwitch(99);
      break;
  }
//DefaultLightSwitch(99);

  if (Serial.available()) { //RECEIVED INFORMATION HANDLER
    timeReceived = Serial.readStringUntil('\n');
  }
}

void DefaultLightSwitch(int lightModeIndex) {
  switch (lightModeIndex) {
    case 0: //Sunshine
      analogWrite(ADJUSTR, 0);
      analogWrite(ADJUSTG, 0);
      analogWrite(ADJUSTB, 0);
      break;
    case 1: //Cloudy
      analogWrite(ADJUSTR, 100);
      analogWrite(ADJUSTG, 120);
      analogWrite(ADJUSTB, 130);
      break;
    case 2: //Rainy
      analogWrite(ADJUSTR, 5);
      analogWrite(ADJUSTG, 15);
      analogWrite(ADJUSTB, 40);
      break;
    case 3: //Morning
      analogWrite(ADJUSTR, 212);
      analogWrite(ADJUSTG, 205);
      analogWrite(ADJUSTB, 235);
      break;
    case 4: //Dusk
      analogWrite(ADJUSTR, 15);
      analogWrite(ADJUSTG, 175);
      analogWrite(ADJUSTB, 195);
      break;
    case 5: //Night
      analogWrite(ADJUSTR, 0);
      analogWrite(ADJUSTG, 150);
      analogWrite(ADJUSTB, 250);
      break;
    case 6: //PARTY!!!!!!!!!!!1
      Party();
      break;
    case 7: //Study lights
      analogWrite(ADJUSTR, 200);
      analogWrite(ADJUSTG, 50);
      analogWrite(ADJUSTB, 10);
      break;
    case 8: //Meeting lights
      analogWrite(ADJUSTR, 230);
      analogWrite(ADJUSTG, 40);
      analogWrite(ADJUSTB, 0);
      break;
    case 99: //Turn light off
      analogWrite(ADJUSTR, 255);
      analogWrite(ADJUSTG, 255);
      analogWrite(ADJUSTB, 255);
      break;
    default: //Default light
      analogWrite(ADJUSTR, 50);
      analogWrite(ADJUSTG, 180);
      analogWrite(ADJUSTB, 240);
      break;
  }
}

void Party() {
  if (currentInterval >= INTERVAL) { //SENDS THE TEMPERATURE VALUE TO THE PC AT A REGULAR INTERVAL
    currentInterval = 0;
  } else {
    switch (currentInterval) {
      case 0 ... 100:
        digitalWrite(ADJUSTR, HIGH);
        digitalWrite(ADJUSTB, LOW);
        break;
      case 101 ... 200:
        digitalWrite(ADJUSTG, HIGH);
        digitalWrite(ADJUSTR, LOW);
        break;
      case 201 ... 300:
        digitalWrite(ADJUSTB, HIGH);
        digitalWrite(ADJUSTG, LOW);
        break;
    }
    currentInterval += (millis() - lastTime);
    lastTime = millis();
  }
}

enum ButtonState readDebouncedButton() {
  int buttonState = digitalRead(K1);
  if (buttonState != lastButtonState) {
    lastButtonState = buttonState;
    if ((millis() - lastButtonTime) > 20) {
      lastButtonTime = millis();
      if (buttonState == LOW) {
        return PRESSED;
      } else {
        return RELEASED;
      }
    }
  }
  return UNKNOWN;
}
