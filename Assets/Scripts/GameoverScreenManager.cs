using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameoverScreenManager : MonoBehaviour
{

    private void Start()
    {
        LocateWords();
    }






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

        this.gameObject.transform.GetChild(0).GetComponent<Text>().text = inGameWordsWithAllLanguages.gameoverScreen[i, 0];
        this.gameObject.transform.GetChild(3).GetComponent<Text>().text = inGameWordsWithAllLanguages.gameoverScreen[i, 1];
    }

}
