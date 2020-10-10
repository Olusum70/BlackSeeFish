using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish13 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Diplecogaster bimaculata";
        descriptionEN = "The species has pelvic fins modified to create a sucker which is used for clinging to rocks or other hard surfaces. It shows variable colouration and its body is frequently coloured red and is spotted with violet, blue, brown or yellow, and they have a yellowish ventral surface. They are sexually dimorphic and the males show a purple spot, surrounded by yellow, immediately to the rear of their pectoral fin. It has a flattened body and a small head, which is roughly triangular in shape. The single dorsal and anal fin are situated posteriorly near to the tail and both are separate from the caudal fin which sits at the end of a long caudal peduncle. It has large eyes and a short snout which ends in large, fleshy lips and very small gill openings. This is a small fish which grows to 6 centimetres (2.4 in) in total length. D. bimaculata can be confused with the similar Apletodon dentatus, although the two-spotted clingfish extends much further north than the small-headed clingfish, and the best way to distinguish them is from their teeth, which in this species are small and conical and grow in patches and there are no large canine teeth.";
        speed = 5;
        swimmingLevel = 1;
        endangeredLevel = 0;
    }



}
