using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish16 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Chameleon goby";
        descriptionEN = "The chameleon goby can reach 11 centimetres (4.3 in) total length. It is pale greyish-brown with a white-speckled head and two longitudinal black bands extending along the flank from the head to the caudal peduncle. The two dorsal fins may be speckled with white and have a brown longitudinal stripe, and the anal fin an orange or grey band across the centre. Under certain circumstances, this fish can darken in colour so that the black bands are nearly invisible. It is very similar in appearance to the Shimofuri goby (Tridentiger bifasciatus), but it has no white spots on the underside of its head and has a white margin to the second dorsal fin and the anal fins. T. bifasciatus has white spots on both the upper and lower part of the head and an orange-red margin to the second dorsal fin and the anal fins, but lacks the distinctive stripes that T. trigonocephalus has on these fins. T. bifasciatus prefers waters with a salinity of less than 22 parts per thousand, while T. trigonocephalus prefers higher salinities.";
        speed = 5;
        swimmingLevel = 1;
        endangeredLevel = 0;
    }




}
