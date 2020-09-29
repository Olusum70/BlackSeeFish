using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish5 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "European eel";
        descriptionEN = "The European eel (Anguilla anguilla) is a species of eel, a snake-like, catadromous fish. They are normally around 60–80 cm (2.0–2.6 ft) and rarely reach more than 1 m (3 ft 3 in), but can reach a length of up to 1.5 m (4 ft 11 in) in exceptional cases.";
        speed = 5;
        swimmingLevel = 2;
        endangeredLevel = 3;
    }

    private void Update()
    {
        moveFoward();
    }


}
