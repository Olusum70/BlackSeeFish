using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish10 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "John Dory";
        descriptionEN = "John Dory, St Pierre or Peter's Fish, refers to fish of the genus Zeus, especially Zeus faber, of widespread distribution. It is an edible demersal coastal marine fish with a laterally compressed olive-yellow body which has a large dark spot, and long spines on the dorsal fin. The dark spot is used to flash an 'evil eye' if danger approaches. Its large eyes at the front of the head provide it with binocular vision and depth perception, which are important for predators. The John Dory's eye spot on the side of its body also confuses prey, which are scooped up in its big mouth.";
        speed = 5;
        swimmingLevel = 2;
        endangeredLevel = 2;
    }



}
