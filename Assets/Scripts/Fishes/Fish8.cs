using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish8 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Lophius piscatorius";
        descriptionEN = "It has a very large head which is broad, flat, and depressed; the rest of the body appears to be a mere appendage. The wide mouth extends all the way around the anterior circumference of the head, and both jaws are armed with bands of long, pointed teeth. These are inclined inwards, and can be closed so as to offer no impediment to an object gliding towards the stomach, but to prevent its escape from the mouth."; speed = 5;
        endangeredLevel = 2;
        swimmingLevel = 2;
    }

    private void Update()
    {
        moveFoward();
    }


}
