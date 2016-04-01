using UnityEngine;
using System.Collections;

public class MainMenu_Buttons : MonoBehaviour {

    public static GameData gameData;

	// Use this for initialization
	void Start () {
        if (gameData == null)
        {
            gameData = GameObject.FindGameObjectWithTag("GameData").GetComponent<GameData>();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void toNG()
    {
        if (gameData.players > 0)
        {
            Application.LoadLevel("Test Scne");   
        }
    }
}
