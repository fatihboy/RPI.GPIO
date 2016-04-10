# Enterprisecoding Raspberry Pi GPIO library

[![Build Status](https://travis-ci.org/fatihboy/RPI.GPIO.svg?branch=master)](https://travis-ci.org/fatihboy/RPI.GPIO)

This C# library is written for handling Raspberry Pi GPIO functionality. It's a simple wrapper for [Gordon's WiringPi](http://wiringpi.com/) library, a GPIO access library written in C for the BCM2835 used in the Raspberry Pi.

# Nuget Package

https://www.nuget.org/packages/Enterprisecoding.RPI.GPIO


# Version Info

**RPI.GPIO :** 1.1

**Wiring Pi :** 2.32

# Installation

## Installing Pre-Requests

### Raspberry Pi update

Make sure your Raspberry Pi box up-to-date;

```
sudo apt-get update
sudo apt-get upgrade
```

## Install Mono

Install mono-complete;

```
sudo apt-get install mono-complete
```

### Git Client

Install git client;

```
sudo apt-get install git-core
```

### Wiring Pi

Most recent versions of Raspbian comes with pre-installed wiring pi library. If you don't have it install, follow the steps below;

clone latest version of wiringPi;

```
git clone git://git.drogon.net/wiringPi
```

build and install Wiring Pi;
 
```
cd wiringPi
./build
```

In order to work with the library you should create shared libraries;

```
cc -shared wiringPi.o -o libwiringPi.so
cc -shared wiringPiI2C.o -o libwiringPiI2C.so
cc -shared wiringPiSPI.o -o libwiringPiSPI.so
```

## RPI.GPIO Compile

clone latest version of RPI.GPIO;

```
git clone https://github.com/fatihboy/RPI.GPIO.git
```

Compile the solution;

```
cd RPI.GPIO/
MONO_IOMAP=case xbuild /p:Configuration=Release Enterprisecoding.RPI.GPIO.sln
```

Run test application;

```
cd Enterprisecoding.RPI.GPIO.LedTest/bin/Release/
sudo mono Enterprisecoding.RPI.GPIO.LedTest.exe
```

which outputs following lines on my Raspberry Pi 3;

```
Enterprisecoding Raspberry Pi GPIO Library v1.0.0.0
Copyright (c) 2014-2016 Fatih Boy
This is free software with ABSOLUTELY NO WARRANTY.

Raspberry Pi Details:
  Type: Model P3, Revision: 1.2, Memory: 1024MB, Maker: SONY

Looping Pin 0...
```

Note that; sample application will loop through pin 0. Turns On & Off.

# License

LGPL

# More Details...

More details can be found on my blog [http://www.enterprisecoding.com/post/tag/rpi-gpio]
