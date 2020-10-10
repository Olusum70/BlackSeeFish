using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class SinglePlayerUIEffects : MonoBehaviour
{
    static public bool pickedUpForSPUI = false;

    private void Start()
    {
        startingCounter();
    }

    private void Update()
    {
        pickedUpAnims();
    }


    [SerializeField] GameObject booble;
    public static int lastFishesPoint;
    void pickedUpAnims()
    {
        if (pickedUpForSPUI)
        {
            // booble anims
            booble.transform.DOScale(1f, .1f).SetEase(Ease.InExpo);
            booble.transform.DOScale(1.3f, .3f).SetDelay(.15f).SetEase(Ease.OutExpo);
            //-------------
            //show point anims
            switch (lastFishesPoint)
            {
                case 10:
                    break;
                case 20:
                    break;
                case 30:
                    break;
            }

            //-------------


            pickedUpForSPUI = false;
        }
    }

    [SerializeField] Image one, two, three;
    void startingCounter()
    {
        three.transform.DOScale(.9f, .3f).SetEase(Ease.OutExpo).SetDelay(.3f);
        three.transform.DOScale(1, .2f).SetDelay(.6f);
        three.transform.DOScale(.9f, .2f).SetDelay(.8f);
        three.transform.DOScale(0, .3f).SetEase(Ease.InExpo).SetDelay(1);
        
        three.transform.DORotate(Vector3.zero, .3f).SetDelay(.3f).SetEase(Ease.OutExpo);
        three.transform.DORotate(new Vector3(0, 0, 180), .36f).SetDelay(1f).SetEase(Ease.InExpo);

        two.transform.DOScale(.9f, .3f).SetEase(Ease.OutExpo).SetDelay(1.3f);
        two.transform.DOScale(1, .2f).SetDelay(1.6f);
        two.transform.DOScale(.9f, .2f).SetDelay(1.8f);
        two.transform.DOScale(0, .3f).SetEase(Ease.InExpo).SetDelay(2);
        
        two.transform.DORotate(Vector3.zero, .3f).SetDelay(1.3f).SetEase(Ease.OutExpo);
        two.transform.DORotate(new Vector3(0, 0, 180), .36f).SetDelay(2f).SetEase(Ease.InExpo);

        one.transform.DOScale(.9f, .3f).SetEase(Ease.OutExpo).SetDelay(2.3f);
        one.transform.DOScale(1, .2f).SetDelay(2.6f);
        one.transform.DOScale(.9f, .2f).SetDelay(2.8f);
        one.transform.DOScale(0, .3f).SetEase(Ease.InExpo).SetDelay(3);

        one.transform.DORotate(Vector3.zero, .3f).SetDelay(2.3f).SetEase(Ease.OutExpo);
        one.transform.DORotate(new Vector3(0, 0, 180), .36f).SetDelay(3f).SetEase(Ease.InExpo);

    }

    void heartsAnim()
    {

    }

}
