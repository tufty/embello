\ core libraries

<<<board>>>
cr compiletoflash
( core start: ) here dup hex.

include ../flib/stm32l0/usart.fs
\ include ../flib/spi/rf69.fs
\ include ../flib/any/varint.fs
\ include ../flib/i2c/bme280.fs
\ include ../flib/i2c/tsl4531.fs
\ include ../flib/i2c/veml6040.fs
\ include ../flib/i2c/mag3110.fs
\ include ../flib/i2c/oled.fs
\ include ../flib/mecrisp/graphics.fs
\ include ../flib/mecrisp/multi.fs
\ include ../flib/any/digits.fs
\ include ../tlib/oled.fs
\ include ../tlib/numprint.fs

( core end, size: ) here dup hex. swap - .
cornerstone <<<core>>>
compiletoram
