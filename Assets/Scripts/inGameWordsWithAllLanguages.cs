using System.Collections;
using System.Collections.Generic;

static public class inGameWordsWithAllLanguages
{

    //0-EN 1-TR 2-RO 3-KA

    //1
    static public string[,] Login = new string[4, 5] {
        { "User Name:", "User Password:", "Log in", "Sign up", "The user name or password is incorrect" },
        {"Kullanıcı Adı:","Kulanıcı Şifresi:","Giriş yap","Kayıt ol","Kullanıcı adı yada şifre yanlış" },
        {"","","","","" },
        {"","","","","" }

    },
    //2
    Signup = new string[4, 6] {
        { "User Name:", "Password:", "Repeat Password:", "Email:", "Sign up", "Wellcome, lets play" },
        {"Kullanıcı Adı:","Şifre:","Şifreyi Tekrarla:","Eposta:","Kayıt ol","Hoşgeldin, hadi oynayalım" },
        {"","","","","","" },
        {"","","","","","" }
    },
    //3
    MainMenu = new string[4, 3] {
        { "Singleplayer", "Multiplayer", "Setting" },
        {"Tekli Oyuculu","Çoklu Oyunculu","Ayarlar" },
        {"","","" },
        {"","","" }
    },
    //4
    gameoverScreen = new string[4, 2]{
        {"Game Over","Your Point: " },
        {"Oyun Sona Erdi","Puanın: " },
        {"","" },
        {"","" }

    };


}
