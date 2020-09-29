using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{

    protected string nameEN, nameTR, nameKA, nameRO, descriptionEN, descriptionTR, descriptionKA, descriptionRO;
    public string theName, theDescription;
    protected float speed;
    protected float xPos;
    public float[] yPosInterval = new float[2];
    public int whichSide;
    private int mEndangeredLevel = 2;
    public int endangeredLevel { get { return mEndangeredLevel; } set { if (value == 1 || value == 2 || value == 3) mEndangeredLevel = value; else Debug.Log("Nesil tükenme seviyesi 1 (en çok bulunan),2 yada 3(en riskli) olabilir"); } }
    private int mSwimmingLevel = 2;

    public bool isBeingHeld;

    public int swimmingLevel
    {
        get { return mSwimmingLevel; }
        set
        {
            switch (mSwimmingLevel)
            {
                case 1://en alt seviyede
                    yPosInterval[0] = 0; yPosInterval[1] = 2.5f;
                    break;
                case 2://orta seviyede

                    break;
                case 3://üst seviyede

                    break;
                default:
                    break;
            }

        }


    }



    protected void moveFoward()
    {
        float rd = Random.Range(1f, 3f) * speed * Time.deltaTime;
        transform.Translate(rd, 0, 0);
    }

    void Languagechosed(string cLanguage)//this choses the name and description after language had chosen
    {
        switch (cLanguage)
        {
            case "EN":
                theName = nameEN;
                theDescription = descriptionEN;
                break;
            case "TR":
                theName = nameTR;
                theDescription = descriptionTR;
                break;
            case "KA":
                theName = nameKA;
                theDescription = descriptionKA;
                break;
            case "RO":
                theName = nameRO;
                theDescription = descriptionRO;
                break;
        }
    }



}
