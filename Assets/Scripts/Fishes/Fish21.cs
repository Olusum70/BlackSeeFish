using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish21 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = " Pennant coralfish";
        descriptionEN = "The reef bannerfish is a small-sized fish that can reach a maximum length of 25 cm. However, the average size generally observed in the nature oscillates around 15 cm.Its body is compressed laterally, the first rays of its dorsal fin stretch in a long white filament. The background color of its body is white with two large black diagonal bands. Beyond the second black stripe, the dorsal and the caudal fins are yellow. The pectoral fins are also yellow. The head is white, the eyes are black and linked together by a black band. The snout, spotted with black, is a bit stretched with a small terminal protractile (it can be extend) mouth.The juvenile doesn't have yet after the second black stripe any white area like adults.The pennant coralfish can easily be confused with the quite similar schooling bannerfish, (Heniochus diphreutes ). The main and visible differences are: a longer snout for the reef bannerfish and spots on its snout are darker, the pelvic fin of the reef bannerfish is longer and has a rounded end unlike the schooling bannerfish which has a smaller and more angular end.";
        speed = 5;
        swimmingLevel = 2;
        endangeredLevel = 0;
    }




}
