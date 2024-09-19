from machine import Pin
from utime import sleep

lampje = Pin(1, Pin.OUT)

while True:
    lampje.toggle()
    sleep(1)