using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class ControllerSinglePlayer : MonoBehaviour
{

    [SerializeField] InputAction hold;
    Vector2 mousePos;
    GameObject holdingFish;
    bool isClick = false;

    bool firstTimeClick = true;

    private void OnEnable()
    {
        hold.Enable();
    }
    private void OnDisable()
    {
        hold.Disable();
    }


    private void Update()
    {
        if (Mouse.current.leftButton.IsPressed())
        {
            mousePos = Camera.main.ScreenToWorldPoint(hold.ReadValue<Vector2>());

            if (firstTimeClick)
            {
                RaycastHit2D raycastHit = Physics2D.Raycast(mousePos, Vector2.one / 5, 1f);
                if (raycastHit.transform.tag == "fish")
                {
                    holdingFish = GameObject.Find(raycastHit.transform.name);
                    holdingFish.GetComponent<Fish>().isBeingHeld = true;
                }
                firstTimeClick = false;
            }

            holdingFish.transform.position = mousePos;
            Debug.Log(holdingFish.name);
        }
        else
        {
            firstTimeClick = true;
            if (holdingFish != null)
            {
                holdingFish.GetComponent<Fish>().isBeingHeld = false;
                holdingFish = null;
            }
        }
    }

}
