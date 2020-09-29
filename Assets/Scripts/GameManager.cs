using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] FishesList = new GameObject[1];
    float xPos, yPos;
    private static string mChosenLanguage;
    public static string chosenLanguage { get { return mChosenLanguage; } set { if (value == "EN" || value == "TR" || value == "KA" || value == "RO") { mChosenLanguage = value; } else { Debug.Log("Dil seçimi hatası oluştu."); } } }
    public static bool didLanguageChosen = false;

    static GameManager()
    {
        string tem = PlayerPrefs.GetString("CL");
        if (tem == "TR" || tem == "EN" || tem == "RO" || tem == "KA")
            didLanguageChosen = false;
        else didLanguageChosen = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            CreateFish();
    }












    void CreateFish()
    {
        int whichFish = /*Random.Range(0, 29);*/0;

        GameObject theFish = Instantiate(FishesList[whichFish], new Vector2(0, -30), Quaternion.identity);



        theFish.GetComponent<Fish>().whichSide = Random.Range(1, 3);//1 left, 2 right
        if (theFish.GetComponent<Fish>().whichSide == 1)
        {
            xPos = -20;
            theFish.transform.rotation = Quaternion.identity;
        }
        else
        {
            xPos = 20;
            theFish.transform.rotation = new Quaternion(0, 180, 0, 0);
        }



        switch (whichFish)
        {
            case 0:
                yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                break;
                //case 1:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 2:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 3:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 4:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 5:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 6:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 7:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 8:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 9:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 10:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 11:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 12:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 13:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 14:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 15:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 16:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 17:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 18:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 19:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 20:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 21:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 22:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 23:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 24:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 25:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 26:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 27:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 28:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 29:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 30:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;
                //case 31:
                //    yPos = Random.Range(theFish.GetComponent<Fish1>().yPosInterval[0], theFish.GetComponent<Fish1>().yPosInterval[1]);
                //    break;

        }//Chosing creation y point of fish 

        theFish.transform.position = new Vector3(xPos, yPos, 0);


    }



}
