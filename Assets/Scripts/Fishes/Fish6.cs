using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish6 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Twait shad";
        descriptionEN = "The twait shad is a typical herring-type fish and much resembles the allis shad. It has no lateral line and the belly is more rounded than that of the sprat and Baltic herring. The gill cover is ridged and the caudal peduncle has large, plate-like scales. This fish is more colourful than the Baltic herring. The back is a bluish green colour and the head brownish with a golden tinge on the operculum. The flanks are silvery, sometimes with a bronzy tinge, and there are a distinctive row of six to ten large dark spot just behind the gill cover though these may fade when the fish is dead. The adult length is typically 25 to 40 cm (10 to 16 in).";
        speed = 5;
        swimmingLevel = 2;
        endangeredLevel = 1;
    }




}
