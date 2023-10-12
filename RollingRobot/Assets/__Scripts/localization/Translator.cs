using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Translator : MonoBehaviour
{
    const string RU_FONT = "Pattaya-Regular SDF";
    const string EN_FONT = "LuckiestGuy-Regular SDF";
    const string CH_FONT = "ZhiMangXing-Regular SDF";
    const string JP_FONT = "NotoSansJP-Black SDF";
    private const string language = "Language";


    private static int LanguageID; // make it property
    private static List<TranslatableText> ListId = new List<TranslatableText>();

    #region переводы двумерный массив

    private static string[,] translatesArray = //rename to translatesArray
    {
        #region english 0
        {
            "play", //0
            "pause", //1
            "replay", //2
            "resume", //3
            "next", //4
            "menu" //5

        },
        #endregion
         #region russian 1
        {
            "играть",
            "пауза",
            "заново",
            "к игре",
            "дальше",
            "меню"
        },
        #endregion

          #region испанский 2
        {
            "jugar", //0
            "pausa", //1
            "reproducir", //2
            "reanudar", //3
            "siguiente", //4
            "menú" //5
        },
        #endregion

          #region немецкий 3
        {
            "spielen", //0
            "pause", //1
            //"Wiederholung", //2
            "wieder tun", //2

            "fortsetzen", //3
            "weiter", //4
            "menü" //5
        },
        #endregion

          #region турецкий 4
        {
           "oynat", //0
            "duraklatma", //1
            "tekrar oynat", //
            "özgeçmiş", //3
            "sonraki", //
            "menü" //5
        },
        #endregion

          #region иальянский 5
        {
           "riproduci", //0
            "pausa", //1
            "riproduci", //2
            "riprendi", //3
            "successivo", //4
            "menù" //5
        },
        #endregion

          #region китайский 6
        {
           "播放", //0
           "暂停", //1
           "重播", //2
           "简历", //3
           "下一个", //4
           "菜单" //5
        },
        #endregion

          #region японский 7
        {
            "再生",// 0
            "一時停止",//1
            "リプレイ",// 2
            "履歴書",//3
            "次へ",// 4
            "メニュー",//5

        },
        #endregion

          #region португальский/brazil 8
        {
           "jogar", //0
           "pausa", //1
           "repetir", //2
           "retomar", //3
           "próximo", //4
           "menu" //5
        },
        #endregion

          #region французский 9
        {
           "jouer", //0
           "pause", //1
           "rejouer", //2
           "reprendre", //3
           "suivant", //4
           "menu" //5
        }
        #endregion
    };

    #endregion

    static public void SelectLanguage(int id)
    {
        if (id < translatesArray.Length)
        {
            LanguageID = id;
            SetLanguageID(id);
        }

    }

    static public string GetText(int textKey) => translatesArray[LanguageID, textKey];
    static public void Add(TranslatableText txt) => ListId.Add(txt);
    static public void Remove(TranslatableText txt) => ListId.Remove(txt);

    static public void UpdateTexts() //use it in start?
    {
        for (int i = 0; i < ListId.Count; i++)
        {
            ListId[i].UIText.text = translatesArray[LanguageID, ListId[i].textID];

            switch (LanguageID)
            {
                case 0:
                    //add tmp fonts to resources
                    ListId[i].UIText.font = Resources.Load<TMP_FontAsset>(EN_FONT);
                    break;
                case 6:
                //case 7:
                    //add tmp fonts to resources
                    ListId[i].UIText.font = Resources.Load<TMP_FontAsset>(CH_FONT);
                    break;
                case 7:
                    //case 7:
                    //add tmp fonts to resources
                    ListId[i].UIText.font = Resources.Load<TMP_FontAsset>(JP_FONT);
                    break;
                default:
                    ListId[i].UIText.font = Resources.Load<TMP_FontAsset>(RU_FONT);// was EN
                    break;
            }
        }
    }

    static public void SetLanguageID(int ID)
    {
        PlayerPrefs.SetInt(language, ID);

    }
}
