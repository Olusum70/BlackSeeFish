using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish24 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Silver scabbardfish";
        descriptionEN = "The silver scabbardfish (also frostfish, beltfish), Lepidopus caudatus, is a cutlassfish of the family Trichiuridae found throughout the temperate seas of the world. It grows to over 2 metres (6 ft 7 in) in length.";
        speed = 5;
        swimmingLevel = 1;
        endangeredLevel = 0;
    }



}
