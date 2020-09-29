using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserLogManager : MonoBehaviour
{
    [SerializeField] InputField signinUserNameIF, signinUserPasswordIF;
    string signinUserName, signinUserPassword;
    bool isUserInformationRight = true;


    private void Awake()
    {

    }
    private void Start()
    {
        LocateWords();
    }


    public void LoginBtn()
    {
        signinUserName = signinUserNameIF.text;
        signinUserPassword = signinUserPasswordIF.text;
        if (isUserInformationRight)
        {
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            if (incorrectLoginMessage.color.a == 0)
                incorrectLoginMessage.DOFade(1, .5f);
            else
            {
                incorrectLoginMessage.DOFade(.3f, .5f);
                incorrectLoginMessage.DOFade(1, .5f).SetDelay(.5f);
            }
        }
    }


    [SerializeField] GameObject LoginScene, SignupScene;
    public void SignupSceneBtn()
    {
        SignupScene.SetActive(true);
        LoginScene.SetActive(false);
    }

    [SerializeField] InputField nameSignupIF, pass1SignupIF, pass2SignupIF, eMailSignupIF;
    public void SignUpBtn()
    {
        if (pass1SignupIF.text == pass2SignupIF.text)
        {
            if (eMailSignupIF.text.Contains("@") && eMailSignupIF.text.Contains(".com"))
            {
                // Giriş başarılı
            }
            else
            {
                //Geçersiz Email Mesajı
            }
        }
        else
        {
            //şifreler uyuşmuyor mesajı
        }
    }






    [SerializeField] Text incorrectLoginMessage, userNameLogin, userPasswordLogin, LoginBtnTxt, SignUpScreenBtnTxt, userNameSignup, userPassword1Signup, userPassword2Signup, EmailTxtSignup, SignupBtn;
    [SerializeField] Text signupSucceedMessageTxt;
    void LocateWords() //Klasik kelime yerleştirme metodu
    {
        int i = 0;

        switch (GameManager.chosenLanguage)
        {
            case "EN": i = 0; break;
            case "TR": i = 1; break;
            case "RO": i = 2; break;
            case "KA": i = 3; break;
        }


        userNameLogin.text = inGameWordsWithAllLanguages.Login[i, 0];
        userPasswordLogin.text = inGameWordsWithAllLanguages.Login[i, 1];
        LoginBtnTxt.text = inGameWordsWithAllLanguages.Login[i, 2];
        SignUpScreenBtnTxt.text = inGameWordsWithAllLanguages.Login[i, 3];
        incorrectLoginMessage.text = inGameWordsWithAllLanguages.Login[i, 4];
        userNameSignup.text = inGameWordsWithAllLanguages.Signup[i, 0];
        userPassword1Signup.text = inGameWordsWithAllLanguages.Signup[i, 1];
        userPassword2Signup.text = inGameWordsWithAllLanguages.Signup[i, 2];
        EmailTxtSignup.text = inGameWordsWithAllLanguages.Signup[i, 3];
        SignupBtn.text = inGameWordsWithAllLanguages.Signup[i, 4];
        signupSucceedMessageTxt.text = inGameWordsWithAllLanguages.Signup[i, 5];
    }


}
