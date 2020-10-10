using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

    private void Start()
    {
        LocateWords();
        goIn();
    }


    public void singlePlayerBtn()
    {
        SceneManager.LoadScene("SinglePlayerGame");
    }

    public void multiPlayerBtn()
    {
        SceneManager.LoadScene("");
    }

    public void settingsBtn()
    {

    }







    [SerializeField] Text singleplayerTxt, multiplayerTxt, settings;
    void LocateWords()
    {
        int i = 0;
        switch (GameManager.chosenLanguage)
        {
            case "EN": i = 0; break;
            case "TR": i = 1; break;
            case "RO": i = 2; break;
            case "KA": i = 3; break;
        }

        singleplayerTxt.text = inGameWordsWithAllLanguages.MainMenu[i, 0];
        multiplayerTxt.text = inGameWordsWithAllLanguages.MainMenu[i, 1];
        settings.text = inGameWordsWithAllLanguages.MainMenu[i, 2];
    }



    // UI Effects-----------

    [SerializeField] Button spBtn, mpBtn, setBtn;

    void goIn()
    {
        spBtn.GetComponent<CanvasGroup>().DOFade(1, .6f).SetDelay(.6f);
        mpBtn.GetComponent<CanvasGroup>().DOFade(1, .6f).SetDelay(.3f);
        setBtn.GetComponent<CanvasGroup>().DOFade(1, .6f);

    }
}
