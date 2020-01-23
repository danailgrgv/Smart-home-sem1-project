/*
  Ambitemp.cpp - A simplification layer for SimpleDHT.
  Created by Kristiyan Angelov, December 9, 2019.
  Released into the public domain.
  
  All components of SimpleDHT are part of the MIT License
  and as such are not part of the license stated for this
  file.
*/

#include "Ambitemp.h"

void Ambitemp::initialize(uint8_t pin) {
    _pin = pin;
    _temperature = 0;
    _humidity = 0;
    _lastms = 0;
    _dht11 = SimpleDHT11(pin);
    // override to get first measurement
    getData(true);
}

uint8_t Ambitemp::getData(bool override) {
    // throttle sample rate or force override
    if (millis() - _lastms >= DHT11_SAMPLE_RATE || override) {
        uint8_t err = SimpleDHTErrSuccess;
        uint8_t temperature;
        uint8_t humidity;

        err = _dht11.read(&temperature, &humidity, NULL);
        if (err != SimpleDHTErrSuccess) {
            return err;
        }
        
        _temperature = temperature;
        _humidity = humidity;

        _lastms = millis();
    }
    return SimpleDHTErrSuccess;
}

uint8_t Ambitemp::getTemperature() {
    getData();
    return _temperature;
}

uint8_t Ambitemp::getHumidity() {
    getData();
    return _humidity;
}
