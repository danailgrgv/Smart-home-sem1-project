/*
  Ambitemp.h - A simplification layer for SimpleDHT.
  Created by Kristiyan Angelov, December 9, 2019.
  Released into the public domain.
  
  All components of SimpleDHT are part of the MIT License
  and as such are not part of the license stated for this
  file.
*/

#ifndef _AMBITEMP_H
#define _AMBITEMP_H

#include <Arduino.h>
#include "SimpleDHT.h"

// 1HZ sample rate on the DHT11
#define DHT11_SAMPLE_RATE 1000

class Ambitemp {
    public:
        void initialize(uint8_t pin);
        uint8_t getTemperature();
        uint8_t getHumidity();

    private:
        uint8_t getData(bool override = false);
        uint8_t _pin;
        uint8_t _temperature;
        uint8_t _humidity;
        SimpleDHT11 _dht11;
        unsigned long _lastms;
};

#endif
