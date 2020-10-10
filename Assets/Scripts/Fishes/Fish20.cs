using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish20 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Spicara maena";
        descriptionEN = "Spicara maena is a fairly deep-bodied fish, with males reaching a maximum length of about 25 cm (10 in) and females 21 cm (8 in). The upper jaw is protrusible and the mouth contains several rows of small teeth. The single dorsal fin has eleven spines and twelve soft rays and the anal fin has three spines and nine or ten soft rays. There are sixty-eight to seventy scales on the lateral line. This fish is blue-grey above with silvery sides and a scattering of small dark spots. There is usually one large dark blotch above the tip of the pectoral fin. Spicara maena is a rather variable species. It has many synonyms across its wide range and is often confused with the common picarel Spicara smaris.";
        speed = 5;
        swimmingLevel = 2;
        endangeredLevel = 0;
    }


}
