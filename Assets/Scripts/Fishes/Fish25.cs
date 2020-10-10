﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish25 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Swordfish";
        descriptionEN = "Swordfish (Xiphias gladius), also known as broadbills in some countries, are large, highly migratory, predatory fish characterized by a long, flat, pointed bill. They are a popular sport fish of the billfish category, though elusive. Swordfish are elongated, round-bodied, and lose all teeth and scales by adulthood. These fish are found widely in tropical and temperate parts of the Atlantic, Pacific, and Indian Oceans, and can typically be found from near the surface to a depth of 550 m (1,800 ft), and exceptionally up to depths of 2,234 m. They commonly reach 3 m (9.8 ft) in length, and the maximum reported is 4.55 m (14.9 ft) in length and 650 kg (1,430 lb) in weight.";
        speed = 5;
        swimmingLevel = 2;
        endangeredLevel = 0;
    }



}
