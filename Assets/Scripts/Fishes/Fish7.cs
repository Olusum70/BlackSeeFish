using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish7 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Round sardinella";
        descriptionEN = "Sardinella aurita has a particularly elongated body, a relatively rounded belly, and a large number of fine gill rakers (up to 160). This is one of the largest Sardinella species, averaging 23 to 28 cm. It has eight pelvic fin rays. It has frontoparietal stripes on the top of its head, a faint golden midlateral line, and a distinctive black spot on the hind border of the gill cover. It is often caught along with Sardinella longiceps, and the two are not easily distinguished.";
        speed = 5;
        endangeredLevel = 1;
        swimmingLevel = 2;
    }




}
