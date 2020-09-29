using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish11 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Long-snouted seahorse";
        descriptionEN = "The long-snouted seahorse is a small-sized fish that can reach a maximum length of 21.5 cm but the average size is more or less 12 cm. The body is slender, the snout is long and the tail is prehensile. Its head and dorsal ridge have often some more or less long and numerous dermal filaments which can be simple or bifid. Its color ranges from dark green to different variants of brown to yellow, the body is often speckled with small white dots.";
        speed = 5;
        endangeredLevel = 1;
        swimmingLevel = 2;
    }




}
