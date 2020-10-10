using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish27 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Scophthalmus";
        descriptionEN = "Scophthalmus maeoticus (Black Sea turbot or kalkan) is a fish species in the family Scophthalmidae. It is widespread in the Black Sea. It is sometimes treated as a subspecies of the turbot, Scophthalmus maximus, which is common in the Mediterranean Sea. The taxonomic status of this species is under discussion. It is an important commercial species.";
        speed = 5;
        swimmingLevel = 1;
        endangeredLevel = 0;
    }




}
