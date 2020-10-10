using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish12 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Red gurnard";
        descriptionEN = "Gurnards are very distinctive bottom-living fish with large heads and eyes. The head is protected by large bony plates and strong spines. The lower three rays of the pectoral fins are separate, finger-like processes that contain sensory organs. These are used by the gurnard to 'feel' for small fish, crustaceans and other invertebrates living in the sediment. The red gurnard has a stout body, large head and eyes and moderately large scales. It is one of the smallest of the European gurnards reaching a maximum length of 40 cm (16 in). The coloration is bright red with pinkish-silver mottling on the sides and head. The protective bony plates on the head which are characteristic of all gurnards are very conspicuous in this species. Along the lateral line there is a row of large, plate-like scales. The divided dorsal fin has nine spines and seventeen to eighteen soft rays while the anal fin has no spines and sixteen to eighteen soft rays.";
        speed = 5;
        swimmingLevel = 1;
        endangeredLevel = 0;
    }



}
