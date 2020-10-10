using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish19 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Chromis chromis";
        descriptionEN = "Chromis chromis has an oval and laterally compressed body with an noticeably large eye. Its mouth is strongly protractile, reaching to below the centre of the eye, with small canine-like teeth set in 3 rows on the jaws. The preoperculum is not serrated and the anterior gill arch has 30 slender gill rakers. There are 13-14 spines and 10-11 soft rays in the dorsal fin and in the anal fin has 11 spines and 10-12 soft rays. Its body is covered in large scales, including the head, and there are 24-30 scales along the lateral line. The youngest fish are a brilliant iridescent blue in colour; older juveniles have blue stripes with the dorsal and anal fins outlined in blue while the adults are dark brown with the centres of each scale a paler golden brown or grey-brow and with the edge of the caudal fin lacking any colour, especially in the centre of the fork. The males become a vivid pale violet. There is a single pair of nostrils.It can grow up to a size of 25 centimetres (9.8 in) in length, with a common length of 13 centimetres (5.1 in).";
        speed = 5;
        swimmingLevel = 2;
        endangeredLevel = 0;
    }



}
