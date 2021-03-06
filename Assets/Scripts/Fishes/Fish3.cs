﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish3 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Persian sturgeon";
        descriptionEN = "The Persian sturgeon (Acipenser persicus) is a species of fish in the family Acipenseridae. It is found in the Caspian Sea and to a lesser extent the Black Sea and ascends certain rivers to spawn, mainly the Volga, Kura, Araks and Ural Rivers. It is heavily fished for its flesh and its roe and is limited in its up-river migrations by damming of the rivers. Young fish feed on small invertebrates, graduating to larger prey such as crabs and fish as they grow. The threats faced by this fish include excessive fishing with the removal of immature fish before they have bred, damming of the rivers, loss of spawning areas and water pollution. The International Union for Conservation of Nature has listed the fish as critically endangered and has suggested that the increased provision of hatcheries could be of benefit.";
        speed = 5;
        endangeredLevel = 3;
        swimmingLevel = 2;
    }




}
