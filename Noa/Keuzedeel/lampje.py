from machine import Pin
from utime import sleep

lampje = Pin(2, Pin.OUT)

while True:
    lampje.toggle()
    sleep(1)