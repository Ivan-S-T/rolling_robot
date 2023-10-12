using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class YandexSDK : MonoBehaviour
{

    /*
   
    public static YandexSDK Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        //Authenticate();
    }



    //UserGameData UGD;
    //private UserData UD;

    //public UserGameData GetUserGameData => UGD;

    //public UserData GetUserData => UD;
    //
    #region DLLImport
    [DllImport("__Internal")]
    private static extern void Auth();    // Авторизация - внешняя функция для связи с плагином
    [DllImport("__Internal")]
    private static extern void ShowCommonADV();    // Показ обычной рекламы - внешняя функция для связи с плагином
    [DllImport("__Internal")]
    private static extern void GetData();    // Получение данных - внешняя функция для связи с плагином
    [DllImport("__Internal")]
    private static extern void SetData(string data);    // Отправка данных - внешняя функция для связи с плагином
    [DllImport("__Internal")]
    private static extern void ShowRewardADV();    // Показ рекламы с наградой - внешняя функция для связи с плагином

    [DllImport("__Internal")]
    private static extern void AskFeedback();
    #endregion DLLImport

    // public event Action AuthSuccess;    //События
    // public event Action DataGet;    //События
    //public event Action RewardGet;  //События


    public void Authenticate()    //    Авторизация
    {
        Auth();
    }

    public void GettingData()    // Получение данных
    {
        GetData();
    }

    public void SettingData(string data)    // Сохранение данных
    {
        SetData(data);
    }

    public void ShowCommonAdvertisment()    // Показ обычной рекламы
    {
        ShowCommonADV();
    }

    public void ShowRewardAdvertisment()    // Показ рекламы с наградой
    {
        ShowRewardADV();
    }


    //public void AuthenticateSuccess(string data)    // Авторизация успешно пройдена
    //{
    //    UD.Name = data;
    //    AuthSuccess?.Invoke();
    //}

    //public void DataGetting(string data) // Данные получены
    //{
    //    UserDataSaving UDS = new UserDataSaving();
    //    UDS = JsonUtility.FromJson<UserDataSaving>(data);
    //    UGD = JsonUtility.FromJson<UserGameData>(UDS.data);
    //    DataGet?.Invoke();
    //}

    //public void RewardGetting() // Реклама просмотрена
    //{
    //    RewardGet?.Invoke();
    //}

    public void AskForFeedback()
    {
        AskFeedback();
        



        // ysdk.feedback.canReview()
        //.then(({ value, reason }) => {
        //    if (value) {
        //        ysdk.feedback.requestReview()
        //            .then(({ feedbackSent }) => {
        //                console.log(feedbackSent);
        //            })
        //    } else {
        //        console.log(reason)
        //    }
        //})
        
    }

    */
}

//[Serializable]
//public class UserData
//{
//    public string Name;
//}

//[Serializable]
//public class UserGameData
//{
//    public UserGameData(int coin)
//    {
//        Coin = coin;
//    }
//    public int Coin;
//}

//[Serializable]
//public class UserDataSaving
//{
//    public string data;
//}


