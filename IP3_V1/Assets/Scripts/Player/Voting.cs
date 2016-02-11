using UnityEngine;
using System.Collections;

public class Voting : MonoBehaviour {

    //Declarations
    public bool IsVoting;
    int noOfPlayers;
    string P1Vote;
    string P2Vote;
    string P3Vote;
    string P4Vote;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vote();
	}

    public void Vote()
    {
        if (!IsVoting)
        {
            IsVoting = true;
        }
        else if (IsVoting)
        {
            //Check apparent number of players.
            noOfPlayers = Input.GetJoystickNames().Length;
            Debug.Log("Players present: " + noOfPlayers);

            //A = 0, B = 1, X = 2, Y = 3
            //A = P1, B = P2, X = P3, Y = P4


        }
    }
}
