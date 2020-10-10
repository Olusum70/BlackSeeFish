using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish22 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Common percarina";
        descriptionEN = "The common percarina is distinguished from its congener P. maeotica by having no scales on its cheek, by having nearly transparent membranes on the body and fins, the upper body is milky white in colour with no spots. It also has 8-9 round or irregular markings on the base of both dorsal fins. The dorsal fins are clearly separate in both species of Percarina and in this species the first dorsal fin contains 9-10 spines while the second dorsal fin contains 3 spines and 10-12 soft rays. The anal fin has 2 spines and 8-11 soft rays. this species has a maximum published standard length of 10 centimetres (3.9 in).";
        speed = 5;
        swimmingLevel = 2;
        endangeredLevel = 0;
    }




}
