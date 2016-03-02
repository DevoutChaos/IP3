using UnityEngine;
using System.Collections;

public class MainMenu_Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void toNG()
    {
        Application.LoadLevel("BasicTest1_Voting");
    }
}
