using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish23 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Painted comber";
        descriptionEN = "The painted comber has a laterally compressed, elongate body with a pointed snout. The dorsal fin has 10 spines and 4-16 soft rays and the anal fin has 3 spines and 7-8 soft rays. The caudal fin is truncate. It has a very large mouth for its size, which has many sharp teeth, and is protractile. The overall colour may be grey, purplish or reddish with 5-7 dark brown bars on the flanks> The head is marked with many narrow, wavy blue lines and red blotches. The dorsal, anal and caudal fins are marked with red dots. There is a diffuse, purplish-blue blotch in the middle of the body. The pelvic and pectoral fins are normally uniform pale yellow. The maximum recorded fish measurement is 36 centimetres (14 in), although 25 centimetres (9.8 in) is more typical";
        speed = 5;
        swimmingLevel = 2;
        endangeredLevel = 0;
    }



}
