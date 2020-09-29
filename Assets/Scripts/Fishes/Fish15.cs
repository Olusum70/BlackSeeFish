using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish15 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Russian Sturgeon";
        descriptionEN = "The Russian sturgeon can grow to 210 cm (83 in) but a more normal size is 110 to 140 cm (43 to 55 in). It has a relatively short and rounded snout with three pairs of unfringed barbels closer to the tip of the snout that to the mouth. The dorsal fin has 27 to 48 soft rays and the anal fin has 16 to 35. The number of scales along the lateral line varies from 21 to 50. This fish can be distinguish from the otherwise similar starry sturgeon by the shape of its snout, its barbels and scale arrangement. The upper surface is greyish-green, the lateral scales are pale and the belly white.";
        speed = 5;
        yPosInterval[0] = 0; yPosInterval[1] = 2.5f;
    }




}
