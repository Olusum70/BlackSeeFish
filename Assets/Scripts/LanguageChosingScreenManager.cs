using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class LanguageChosingScreenManager : MonoBehaviour
{
    [SerializeField] Image blackPanel;
    [SerializeField] Text choseYourLanguageText, TRTxt, ENTxt, ROTxt, KATxt;

    private void Start()
    {
        if (GameManager.didLanguageChosen)
        {
            blackPanel.DOFade(0, 1.2f).SetDelay(1.5f);
            choseYourLanguageText.DOFade(1, .5f).SetDelay(.5f);
            choseYourLanguageText.DOFade(0, 1.2f).SetDelay(2.5f);
        }
        else
        {
            SceneManager.LoadScene("LoginScene");
            Debug.Log(PlayerPrefs.GetString("CL"));
        }
    }

    public void TRChosed()
    {

        GameManager.chosenLanguage = "TR";
        PlayerPrefs.SetString("CL", GameManager.chosenLanguage);
        blackPanel.DOFade(1, 2);
        TRTxt.DOFade(1, 2).SetDelay(1);
        TRTxt.DOFade(0, .5f).SetDelay(4);
        StartCoroutine(GoToNextScene());
    }

    public void ENChosed()
    {
        GameManager.chosenLanguage = "EN";
        PlayerPrefs.SetString("CL", GameManager.chosenLanguage);
        blackPanel.DOFade(1, 2);
        ENTxt.DOFade(1, 2).SetDelay(1);
        ENTxt.DOFade(0, .5f).SetDelay(4);
        StartCoroutine(GoToNextScene());
    }
    public void KAChosed()
    {
        GameManager.chosenLanguage = "KA";
        PlayerPrefs.SetString("CL", GameManager.chosenLanguage);
        blackPanel.DOFade(1, 2);
        KATxt.DOFade(1, 2).SetDelay(1);
        KATxt.DOFade(0, .5f).SetDelay(4);
        StartCoroutine(GoToNextScene());
    }
    public void ROChosed()
    {
        GameManager.chosenLanguage = "RO";
        PlayerPrefs.SetString("CL", GameManager.chosenLanguage);
        blackPanel.DOFade(1, 2);
        ROTxt.DOFade(1, 2).SetDelay(1);
        ROTxt.DOFade(0, .5f).SetDelay(4);
        StartCoroutine(GoToNextScene());
    }




    IEnumerator GoToNextScene()
    {
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene("LoginScene");
    }

}
