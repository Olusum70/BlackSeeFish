using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish4 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Starry sturgeon";
        descriptionEN = "The starry sturgeon reaches about 220 cm (7.2 ft) in length and weighs up to 80 kg (180 lb). It is a slim-bodied fish easily distinguished from other sturgeons by its long, thin and straight snout. A row of five small barbels lies closer to the mouth than to the tip of the snout. The scales on the lateral line number between thirty and forty and these features distinguish this fish from the Russian sturgeon (Acipenser gueldenstaedtii). Its general colouring is dark greyish-green or brown with a pale underside. The scales on the lateral line are pale. The maximum reported age for this species is 27 years."; 
        speed = 5;
        endangeredLevel = 3;
        swimmingLevel = 2;
    }




}
