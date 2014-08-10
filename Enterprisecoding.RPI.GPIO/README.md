Enterprisecoding Raspberry Pi GPIO library
=========

This C# library is written for handling Raspberry Pi GPIO functionality. It's a simple wrapper for [Gordon's WiringPi](http://wiringpi.com/) library, a GPIO access library written in C for the BCM2835 used in the Raspberry Pi.


Version
----

1.0


Installation
--------------
In order to work with the library you should first install WiringPi and create shared libraries;

```
cc -shared wiringPi.o -o libwiringPi.so
cc -shared wiringPiI2C.o -o libwiringPiI2C.so
cc -shared wiringPiSPI.o -o libwiringPiSPI.so
```

You can run test application;

```
sudo mono Enterprisecoding.RPI.GPIO.Test.exe
```

which outputs following lines on my Raspberry Pi B+;

```
Enterprisecoding Raspberry Pi GPIO Library v1.0.0.0
Copyright (c) 2014-2014 Fatih Boy
This is free software with ABSOLUTELY NO WARRANTY.

Raspberry Pi Details:
  Type: Model B+, Revision: 1.2, Memory: 512MB, Maker: SONY

Application will loop through pin 15. Make sure nothing connected!
Press escape to cancel or any other to continue...

Looping Pin 15...
```

Note That; sample application will loop through pin 15. Turns On & Off.

License
----

LGPL

More Details...
----
More details can be found on my blog [http://enterprisecoding.com]