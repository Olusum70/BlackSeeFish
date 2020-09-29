using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish2 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Spiny dogfish";
        descriptionEN = "Males mature at around 11 years of age, growing to 80–100 cm (31–39 in) in length; females mature in 18–21 years and are slightly larger than males, reaching 98.5–159 cm (38.8–62.6 in). Both sexes are greyish brown in color and are countershaded. Males are identified by a pair of pelvic fins modified as sperm-transfer organs, or \"claspers\". The male inserts one clasper into the female cloaca during copulation.";
        speed = 10;
        endangeredLevel = 2;
        swimmingLevel = 2;
    }

    private void Update()
    {
        moveFoward();
    }


}
