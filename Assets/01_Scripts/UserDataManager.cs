using System.Collections;
using Proyecto26;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UserDataManager : MonoBehaviour{
     
    public PlayerData_SO playerData;
    public static UserDataManager instance;

    void Awake() {
        if(instance == null)
            instance = this;
        else
            Destroy(this);
        DontDestroyOnLoad(this);
    }

    void Start() {
        GameSaveManager.instance.LoadGame();
        // ResetAllData();
    }

    public void AddDataPiece(float time, string currentLevel, string buttonPressed, bool correct, int inputsCount) {
        playerData.AddDataPiece(time, currentLevel, buttonPressed, correct, inputsCount);
        UserData user=new UserData(time, currentLevel, buttonPressed, correct, inputsCount);
        RestClient.Post("https://minihack2020-grumosas.firebaseio.com/.json", user);
    }
    

    public void ResetAllData(){
        playerData.userDataPieces = new List<UserDataPiece>();
        CSVManager.CreateReport();
        GameSaveManager.instance.SaveGame();
    }
}