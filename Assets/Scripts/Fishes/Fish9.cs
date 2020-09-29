using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish9 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Garfish";
        descriptionEN = "The garfish is a long and slender fish with a laterally compressed body, and grows to about 50 to 75 cm (20 to 30 in) in length. The jaws are elongated and armed with sharp teeth. The pectoral, dorsal, and anal fins are situated well back on the body and the latter two are similar in appearance. Positioning the fins so far back gives greater flexibility to the body. The lateral line is set low on the flanks. The colour of the body is bluish green with a silvery grey belly and the bones are green.";
        speed = 5;
        swimmingLevel = 2;
        endangeredLevel = 2;
    }




}
