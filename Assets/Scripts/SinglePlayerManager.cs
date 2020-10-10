using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SinglePlayerManager : MonoBehaviour
{

    static public int point, time = 90, health = 3, QuestionDue = 3;
    /*[System.NonSerialized]*/
    public bool didGameStart = true;


    private void Awake()
    {
        staticHearts = hearts;
    }

    private void Start()
    {
        didGameStart = true;
    }



    bool workOnceUpdate = true;
    private void Update()
    {
        if (didGameStart)
        {
            if (workOnceUpdate)
            {
                workOnceUpdate = false;
                spawnSpesifikFish();
            }
            timers();
            couldCatch();
            couldNotCatch();
            gameOver();
            othersSpawner();
        }
        goingDark();
    }



    [SerializeField] GameObject[] hearts;
    static public GameObject[] staticHearts;// static variable lara interface'den atama yapmak için çift değişken kullanma yöntemi
    void getDamage()
    {
        if (health == 3) hearts[2].SetActive(false);
        else if (health == 2) hearts[1].SetActive(false);
        else hearts[0].SetActive(false);
        health--;

    }

    public static void healthGained()
    {
        if (health == 2)
        {
            staticHearts[2].SetActive(true);
            health = 3;

        }
        else if (health == 1)
        {
            staticHearts[1].SetActive(true);
            health = 2;
        }
        else if (health == 0)
        {
            staticHearts[0].SetActive(true);
            health = 1;
        }
    }


    bool workOnceTimers = true;
    int timer1, startTime;
    float catchTime, gameTime;
    bool firstTimer = true;
    [SerializeField] Text gameTimeTxt;
    void timers()
    {
        if (workOnceTimers)
        {
            startTime = (int)(4 + Time.time);
            workOnceTimers = false;
        }
        gameTime = Time.time - startTime;
        if (Time.time > startTime && Time.time > timer1)
        {
            time--;
            timer1++;
            gameTimeTxt.text = ((int)time).ToString();
            if (firstTimer)
            {
                timer1 = 1 + (int)Time.time;
                didGameStart = true;
                firstTimer = false;
            }
        }
    }

    public static GameObject theFishForSP;
    [SerializeField] Image catchPlaceImage;
    void spawnSpesifikFish()//Yakalanması gereken balığı yaratacak
    {
        theFishForSP = GameManager.CreateFish(GameManager.FishesListS, 0);
        catchPlaceImage.sprite = theFishForSP.GetComponent<SpriteRenderer>().sprite;
    }

    void couldNotCatch()
    {
        if (catchTime < 0)
        {
            getDamage();
            catchTime = 6;

        }
    }


    void couldCatch()
    {
        if (GameManager.pickedUp)
        {
            GameManager.pickedUp = false;
            spawnSpesifikFish();
        }
    }

    float spawnInterval;
    bool workOnceSpawner = true;
    void othersSpawner()
    {
        if (workOnceSpawner)
        {
            spawnInterval = Time.time + 4;
            workOnceSpawner = false;
        }
        if (Time.time > startTime)
            if (Time.time > spawnInterval)
            {
                GameManager.CreateFish(GameManager.FishesListS);
                spawnInterval += 0.5f;
            }

    }


    [SerializeField] GameObject darkPanel;
    void goingDark()
    {
        if (gameTime > 60 && gameTime < 62)
        {
            darkPanel.GetComponent<Image>().DOFade(.7f, 26);
            darkPanel.GetComponent<Image>().DOFade(1, 3).SetDelay(26);
        }

    }





    void gameOver()
    {
        if (time < 0 || health <= 0)
        {


            //didGameStart = false;
        }
    }



    void PauseGame()
    {
        Time.timeScale = .05f;
    }



}
