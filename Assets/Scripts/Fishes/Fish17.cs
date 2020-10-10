using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish17 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Mediterranean rainbow wrasse";
        descriptionEN = "It is typically found near the shore in places with seagrass or rocks. It is usually found at depths of 0–60 m (0–197 ft), but occurs as deep as 120 m (390 ft).";
        speed = 5;
        swimmingLevel = 2;
        endangeredLevel = 0;
    }




}
