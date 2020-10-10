using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish14 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Tompot blenny";
        descriptionEN = "The tompot blenny is a relatively large blenny with an elongated body, large head and large eyes which grows to up to 30 centimetres (12 in) in length. The eyes are bicoloured with their top part being brown and the bottom part is white. There is a single branched tentacle over each of its eyes. It is mainly yellow-brown in colour, although occasionally it is greenish and is marked with at least seven dark bars starting at the dorsal fin and which reach the belly. As well as the tentacles over the eyes there are also tentacles over the nostrils. The lateral line is continuous but becomes broken towards the tail. The breeding males become chocolate brown in colour and develop bulb-like glands on the spines of the anal fin. The dorsal fin runs the length of its body and is divided into two halves by a shallow notch. The anterior portion of the fin is contains the spiny rays while the posterior portion contains the soft rays. The dorsal fin has 13-14 spines and 17-20 ray while the anal fin has 2 spines and 19-23 rays. It has relatively large pectoral fins. Each individual has a unique set of markings on the scales of the face which mean that studies of their biology can identify individuals.";
        speed = 5;
        swimmingLevel = 2;//1 de olabilir
        endangeredLevel = 0;
    }



}
