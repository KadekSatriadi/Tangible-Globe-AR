## Creating Custom Tangible Globes

3D print the three .stl files - recommended in a black PLA. The led mount object will need to be duplicated in your 3d printer program in order to print 10x items. For precision, keep in mind that various 3d printers may introduce unpredictable shrinkage, so minor trial and error resizing may be needed for tight tolerances. 

Gently deburr the equator and connector mounts if necessary.

![image_hemispheres](https://github.com/KadekSatriadi/Tangible-Globe-AR/raw/main/Images/image4.jpg)

On each hemisphere, with a 5mm bit, drill five asymmetrically spaced holes, avoiding the poles, and the bottom area of the Southern hemisphere, where the electronics sit. Aim for scalene triangles, with unique distances apart, yet obtaining even coverage over the globe. These holes were  deliberately left off the model to avoid identical objects, and for ease of printing, however feel free to modify the stl files, but supports will be needed, and holes will most likely need to be sized at 5.5mm to adjust for shrinkage. Deburr the holes. 

![image_deburr_holes](https://github.com/KadekSatriadi/Tangible-Globe-AR/raw/main/Images/image5.jpg)

If tight tolerance has been achieved on the led mounts, the IR leds should firmly slot into the flat side of these. Bend Led legs flat.  Solder resistors in series with the anodes. Then glue each led assembly -  with cathodes facing towards their respective poles -  into the drilled globe holes, a small amount of superglue onto the curved printed surface only will suffice. 

![](https://github.com/KadekSatriadi/Tangible-Globe-AR/raw/main/Images/image3.jpg)

Wire the leds in parallel on each hemisphere, I suggest a spiral using 0.7mm bare tinned wire for ground connections.  Install switches, and connectors.

![](https://github.com/KadekSatriadi/Tangible-Globe-AR/raw/main/Images/image7.jpg)


Install matching headers on esp32 board and relay board.Program the esp32, and then using alternating layers of strong adhesive velcro, mount the esp32 to the  battery, and then to the flat surface on the interior of the southern hemisphere. 
Wire up the accelerometer, and relay board. Accelerometer can be modified to fit underneath the relay board by cutting off the unused end of the PCB. 

![](https://github.com/KadekSatriadi/Tangible-Globe-AR/raw/main/Images/image6.png)


On the northern hemisphere, use M3 screws, removing the heads,  or M3 rod to create alignment guides.

![](https://github.com/KadekSatriadi/Tangible-Globe-AR/raw/main/Images/image2.png)


Hemispheres should snap together tightly over the m3 thread, but use thin double sided tape to secure. The above picture shows the aftermath of superglue instead, which was a poor choice.
Wireless Charging coil glues into the bottom of the 3d printed charging stand. Supply with 9v.
Print, cut and apply the gores as shown in this excellent video: https://vimeo.com/90740474
Dark maps look great in the hololens, however will block the Leds if too dark.
The poles will glue over the buttons nicely, wait for the gores to dry before gently pressing the buttons, allowing the paper to gently flex.


![](https://github.com/KadekSatriadi/Tangible-Globe-AR/raw/main/Images/image1.jpg)


## BOM 

| Qty. | Item                                                    | Type                         | Sample link                                                                                       |
|------|---------------------------------------------------------|------------------------------|---------------------------------------------------------------------------------------------------|
|   10 | Infrared Emitter, 850 nm, 35 °, T-1 3/4 (5mm), 85 mW/Sr | 15400585A3590                | https://au.element14.com/wurth-elektronik/15400585a3590/infrared-emitter-850nm-t-1-3-4/dp/2764989 |
|   10 | Through hole resistors 1/4W, 56 - 68 Ohm                |                              |                                                                                                   |
|    2 | 16mm illuminated pushbutton - choice of colours         |                              | https://core-electronics.com.au/metal-pushbutton-momentary-16mm-white.html                        |
|    1 | Accelerometer                                           | ADXL335                      | https://core-electronics.com.au/adxl335-triple-axis-accelerometer-gy-61.html                      |
|    1 | ESP32 Feather microcontroller board                     | ADA3405                      | https://core-electronics.com.au/adafruit-huzzah32-esp32-feather-board.html                        |
|    1 | latching relay board                                    | ADA2923                      | https://core-electronics.com.au/adafruit-latching-mini-relay-featherwing.html                     |
|    1 | LiPo battery 3.7v 1200mAH                               | 1200mah no longer available? | https://core-electronics.com.au/polymer-lithium-ion-battery-1000mah-38458.html                    |
|    1 | Inductive charging set                                  | ADA1407                      | https://core-electronics.com.au/inductive-charging-set-5v-at-500ma-max.html                       |
|    1 | 5pin panel mount connector                              | T 3363 100                   |                                                                                                   |
|    1 | 5pin panel mount connector                              | T 3362 000                   |                                                                                                   |
|    1 | 9v power supply                                         |                              |                                                                                                   |
|      | M3 screws or threaded rod                               |                              |                                                                                                   |
|      | misc wiring                                             |                              |                                                                                                   |
