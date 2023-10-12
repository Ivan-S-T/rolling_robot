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
    private static extern void Auth();    // ����������� - ������� ������� ��� ����� � ��������
    [DllImport("__Internal")]
    private static extern void ShowCommonADV();    // ����� ������� ������� - ������� ������� ��� ����� � ��������
    [DllImport("__Internal")]
    private static extern void GetData();    // ��������� ������ - ������� ������� ��� ����� � ��������
    [DllImport("__Internal")]
    private static extern void SetData(string data);    // �������� ������ - ������� ������� ��� ����� � ��������
    [DllImport("__Internal")]
    private static extern void ShowRewardADV();    // ����� ������� � �������� - ������� ������� ��� ����� � ��������

    [DllImport("__Internal")]
    private static extern void AskFeedback();
    #endregion DLLImport

    // public event Action AuthSuccess;    //�������
    // public event Action DataGet;    //�������
    //public event Action RewardGet;  //�������


    public void Authenticate()    //    �����������
    {
        Auth();
    }

    public void GettingData()    // ��������� ������
    {
        GetData();
    }

    public void SettingData(string data)    // ���������� ������
    {
        SetData(data);
    }

    public void ShowCommonAdvertisment()    // ����� ������� �������
    {
        ShowCommonADV();
    }

    public void ShowRewardAdvertisment()    // ����� ������� � ��������
    {
        ShowRewardADV();
    }


    //public void AuthenticateSuccess(string data)    // ����������� ������� ��������
    //{
    //    UD.Name = data;
    //    AuthSuccess?.Invoke();
    //}

    //public void DataGetting(string data) // ������ ��������
    //{
    //    UserDataSaving UDS = new UserDataSaving();
    //    UDS = JsonUtility.FromJson<UserDataSaving>(data);
    //    UGD = JsonUtility.FromJson<UserGameData>(UDS.data);
    //    DataGet?.Invoke();
    //}

    //public void RewardGetting() // ������� �����������
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


