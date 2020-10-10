using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish26 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Atlantic stargazer";
        descriptionEN = "Typical of stargazers, its body is somewhat dorso-ventrally flattened, lacks a swimbladder, and has been found as large as 35.0 centimeters in length, but is usually between 20–30 cm. Its head and jaws are rotated upward, and has very large eyes and mouth. Its body is brown in color and can have numerous small light spots, with a lighter belly. It lives to about 5 or 6 years, and females are larger in size than males.";
        speed = 5;
        swimmingLevel = 1;
        endangeredLevel = 0;
    }


}
