## Creating custom Tangible Globes

3d print the three stl files - recommended in a black PLA. The led mount object will need to be duplicated in your 3d printer program in order to print 10x items. For precision, keep in mind that various 3d printers may introduce unpredictable shrinkage, so minor trial and error resizing may be needed for tight tolerances. 
Gently deburr the equator and connector mounts if necessary.

On each hemisphere, with a 5mm bit, drill five asymmetrically spaced holes, avoiding the poles, and the bottom area of the Southern hemisphere, where the electronics sit. Aim for scalene triangles, with unique distances apart, yet obtaining even coverage over the globe. These holes were  deliberately left off the model to avoid identical objects, and for ease of printing, however feel free to modify the stl files, but supports will be needed, and holes will most likely need to be sized at 5.5mm to adjust for shrinkage. Deburr the holes. 


If tight tolerance has been achieved on the led mounts, the IR leds should firmly slot into the flat side of these. Bend Led legs flat.  Solder resistors in series with the anodes. Then glue each led assembly -  with cathodes facing towards their respective poles -  into the drilled globe holes, a small amount of superglue onto the curved printed surface only will suffice. 


Wire the leds in parallel on each hemisphere, I suggest a spiral using 0.7mm bare tinned wire for ground connections.  Install switches, and connectors.


Install matching headers on esp32 board and relay board.Program the esp32, and then using alternating layers of strong adhesive velcro, mount the esp32 to the  battery, and then to the flat surface on the interior of the southern hemisphere. 
Wire up the accelerometer, and relay board. Accelerometer can be modified to fit underneath the relay board by cutting off the unused end of pcb. 


On the northern hemisphere, use M3 screws, removing the heads,  or M3 rod to create alignment guides.


Hemispheres should snap together tightly over the m3 thread, but use thin double sided tape to secure. The above picture shows the aftermath of superglue instead, which was a poor choice.
Wireless Charging coil glues into the bottom of the 3d printed charging stand. Supply with 9v.
Print, cut and apply the gores as shown in this excellent video: https://vimeo.com/90740474
Dark maps look great in the hololens, however will block the Leds if too dark.
The poles will glue over the buttons nicely, wait for the gores to dry before gently pressing the buttons, allowing the paper to gently flex.


