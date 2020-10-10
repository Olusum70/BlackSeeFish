using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class theBookManager : MonoBehaviour
{ 
    string Information, name;
    Sprite picture;


    [SerializeField] Transform fishCreating;
    GameObject theFish;

    void ShowChosedFishInformations()
    {

        theFish = Instantiate(GameManager.FishesListS[int.Parse(EventSystem.current.currentSelectedGameObject.name)], fishCreating);
        name = theFish.GetComponent<Fish>().theName;
        Information = theFish.GetComponent<Fish>().theDescription;
        picture = theFish.GetComponent<Image>().sprite;
    }



    void NextPage()
    {

    }

    void PreviousPage()
    {

    }

    void BackToMainPage()
    {

    }



}

//Balık adları listedeki sıralarıyla aynı olmalı.