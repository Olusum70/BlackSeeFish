using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class QuestionBankManager : MonoBehaviour
{

    int dues = 3;
    int howMuchQuestions = 0;
    string theAnswer;


    string[,] questionBankList;

    QuestionBankManager()
    {
        questionBankList = new string[howMuchQuestions, 6]; //0. queation 1-4. answers 5.right answer (must be A,B,C or D)
                                                            // question, answerA, answerB, answerC, answerD;
    }

    private void Start()
    {
        createQuestion();
    }


    bool isRight;
    void answerController()
    {

        if (isRight)
        {
            SinglePlayerManager.healthGained();

        }
        else
        {
            //Yanlış cevap mesajı

        }
        dues--;

    }






    [SerializeField] Text theQuetion;
    void createQuestion()
    {
        if (dues > 0 && SinglePlayerManager.health <= 3)
        {
            int x = howMuchQuestions - 1;
            int chosenQuestion = UnityEngine.Random.Range(0, x);


            theQuetion.text = questionBankList[chosenQuestion, 0];
            theAnswer = questionBankList[chosenQuestion, 5];

        }
        else if (dues <= 0)
        {
            //hak bitti mesajı
        }
        else if (SinglePlayerManager.health == 3)
        {
            //canın zaten ful mesajı
        }
    }

    void answerHadGiven()
    {
        string theAnswer = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        if (theAnswer == this.theAnswer) isRight = true;
        else isRight = false;


        createQuestion();
        answerController();
    }



}
