using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageSetter : MonoBehaviour
{
    private const string language = "Language";
    // public static int LanguageID { get; private set; }

    private void Awake()
    {

        if (PlayerPrefs.HasKey(language) == false)    //this is right

        {
            int LanguageID;
            //LanguageID = 1;
            SystemLanguage systemLanguage = Application.systemLanguage;
            
            switch (systemLanguage)
            {
                case SystemLanguage.Belarusian:
                case SystemLanguage.Bulgarian:
                case SystemLanguage.Estonian:
                case SystemLanguage.Latvian:
                case SystemLanguage.Lithuanian:
                case SystemLanguage.Ukrainian:
                case SystemLanguage.Russian:
                    LanguageID = 1;
                    break;
                case SystemLanguage.Spanish:
                    LanguageID = 2;
                    break;
                case SystemLanguage.German:
                    LanguageID = 3;
                    break;
                case SystemLanguage.Turkish:
                    LanguageID = 4;
                    break;
                case SystemLanguage.Italian:
                    LanguageID = 5;
                    break;
                case SystemLanguage.ChineseSimplified:
                    LanguageID = 6;
                    break;
                case SystemLanguage.Japanese:
                    LanguageID = 7;
                    break;
                case SystemLanguage.Portuguese:
                    LanguageID = 8;
                    break;
                case SystemLanguage.French:
                    LanguageID = 9;
                    break;
                default:
                    LanguageID = 0;
                    break;
            } 
            //  PlayerPrefs.SetInt(language, LanguageID);
            Translator.SetLanguageID(LanguageID);
        }
        Translator.SelectLanguage(PlayerPrefs.GetInt(language));

    }

}
