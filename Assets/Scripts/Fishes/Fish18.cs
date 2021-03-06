﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish18 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Five-spotted wrasse";
        descriptionEN = "The five-spotted wrasse (Symphodus roissali) is a species of wrasse native to the eastern Atlantic Ocean from Spain to Morocco and through the coastal waters of the Mediterranean Sea and the Black Sea. This species inhabits rocky areas usually within beds of eelgrass at depths from 1 to 30 m (3.3 to 98.4 ft). It can reach 17 cm (6.7 in) in standard length, though usually not more than 12 cm (4.7 in). This species is sought by local peoples as a food fish and can also be found in the aquarium trade.";
        speed = 5;
        swimmingLevel = 2;
        endangeredLevel = 0;
    }




}
