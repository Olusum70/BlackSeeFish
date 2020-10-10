using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class SinglePlayerController : MonoBehaviour
{

    [SerializeField] InputAction hold, holdBtn;
    Vector2 mousePos;
    GameObject holdingFish = null;
    bool isClick = false;

    bool firstTimeClick = true;

    private void OnEnable() { hold.Enable(); }
    private void OnDisable() { hold.Disable(); }

    private void Update()
    {
        controller();
    }













    void controller()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            mousePos = Camera.main.ScreenToWorldPoint(hold.ReadValue<Vector2>());

            if (firstTimeClick)
            {
                Debug.Log("?");
                RaycastHit2D raycastHit = Physics2D.Raycast(mousePos, Vector2.one / 5, 1f);

                if (raycastHit.transform.tag == "fish")
                {
                    holdingFish = GameObject.Find(raycastHit.transform.name);
                    holdingFish.GetComponent<Fish>().isBeingHeld = true;
                }
                firstTimeClick = false;
            }
            if (holdingFish != null)
                holdingFish.transform.position = new Vector3(mousePos.x, mousePos.y, 90);
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

    public void bringFish()
    {

        mousePos = Camera.main.ScreenToWorldPoint(hold.ReadValue<Vector2>());

        if (firstTimeClick)
        {
            Debug.Log("?");
            RaycastHit2D raycastHit = Physics2D.Raycast(mousePos, Vector2.one / 5, 1f);

            if (raycastHit.transform.tag == "fish")
            {
                holdingFish = GameObject.Find(raycastHit.transform.name);
                holdingFish.GetComponent<Fish>().isBeingHeld = true;
            }
            firstTimeClick = false;
        }
        holdingFish.transform.position = new Vector3(mousePos.x, mousePos.y, 90);
    }


    public void stopNavigate()
    {
        firstTimeClick = true;
        if (holdingFish != null)
        {
            holdingFish.GetComponent<Fish>().isBeingHeld = false;
            holdingFish = null;
        }
    }
}
