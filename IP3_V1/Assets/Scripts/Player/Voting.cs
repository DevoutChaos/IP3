using UnityEngine;
using System.Collections;

public class Voting : MonoBehaviour
{

    //Declarations
    public bool IsVoting;
    public int noOfPlayers;
    public int P1Vote;
    public int P2Vote;
    public int P3Vote;
    public int P4Vote;

    public bool p1Voted;
    public bool p2Voted;
    public bool p3Voted;
    public bool p4Voted;

    public bool P1Enabled = true;
    public bool P2Enabled = true;
    public bool P3Enabled = true;
    public bool P4Enabled = true;

    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;

    // Use this for initialization
    void Start()
    {
        p1Voted = false;
        p2Voted = false;
        p3Voted = false;
        p4Voted = false;

        //Check apparent number of players.
        //noOfPlayers = Input.GetJoystickNames().Length;
        noOfPlayers = 4;
        Debug.Log("Players present: " + noOfPlayers);

        if (!IsVoting)
        {
            IsVoting = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vote();
        PlayerChecks();
    }

    public void Vote()
    {

        if (IsVoting)
        {
            //A = 0, B = 1, X = 2, Y = 3
            //A = P1, B = P2, X = P3, Y = P4
            if (noOfPlayers > 3)
            {
                if (!p4Voted)
                {
                    if (Input.GetButtonUp("P4voteP1"))
                    {
                        P1Vote++;
                        p4Voted = true;
                    }
                    if (Input.GetButtonUp("P4voteP2"))
                    {
                        P2Vote++;
                        p4Voted = true;
                    }
                    if (Input.GetButtonUp("P4voteP3"))
                    {
                        P3Vote++;
                        p4Voted = true;
                    }
                    if (Input.GetButtonUp("P4voteP4"))
                    {
                        P4Vote++;
                        p4Voted = true;
                    }
                }
            }
            if (noOfPlayers > 2)
            {
                if (!p3Voted)
                {
                    if (Input.GetButtonUp("P3voteP1"))
                    {
                        P1Vote++;
                        p3Voted = true;
                    }
                    if (Input.GetButtonUp("P3voteP2"))
                    {
                        P2Vote++;
                        p3Voted = true;
                    }
                    if (Input.GetButtonUp("P3voteP3"))
                    {
                        P3Vote++;
                        p3Voted = true;
                    }
                    if (Input.GetButtonUp("P3voteP4") && noOfPlayers > 3)
                    {
                        P4Vote++;
                        p3Voted = true;
                    }
                }
            }
            if (noOfPlayers > 1)
            {
                if (!p2Voted)
                {
                    if (Input.GetButtonUp("P2voteP1"))
                    {
                        P1Vote++;
                        p2Voted = true;
                    }
                    if (Input.GetButtonUp("P2voteP2"))
                    {
                        P2Vote++;
                        p2Voted = true;
                    }
                    if (Input.GetButtonUp("P2voteP3") && noOfPlayers > 2)
                    {
                        P3Vote++;
                        p2Voted = true;
                    }
                    if (Input.GetButtonUp("P2voteP4") && noOfPlayers > 3)
                    {
                        P4Vote++;
                        p2Voted = true;
                    }
                }
            }
            if (!p1Voted)
            {
                if (Input.GetButtonUp("P1voteP1"))
                {
                    P1Vote++;
                    p1Voted = true;
                }
                if (Input.GetButtonUp("P1voteP2") && noOfPlayers > 1)
                {
                    P2Vote++;
                    p1Voted = true;
                }
                if (Input.GetButtonUp("P1voteP3") && noOfPlayers > 2)
                {
                    P3Vote++;
                    p1Voted = true;
                }
                if (Input.GetButtonUp("P1voteP4") && noOfPlayers > 3)
                {
                    P4Vote++;
                    p1Voted = true;
                }
            }

            switch (noOfPlayers)
            {
                case 1:
                    if (p1Voted)
                    {
                        Debug.Log("Player 1 voted _ Case 1");
                    }
                    break;

                case 2:
                    if (p1Voted && p2Voted)
                    {
                        if (P1Vote > P2Vote)
                        {
                            Debug.Log("Player 1 voted _ Case 2");
                            P1Enabled = false;
                            IsVoting = false;
                        }
                        else if (P2Vote > P1Vote)
                        {
                            Debug.Log("Player 2 voted _ Case 2");
                            P2Enabled = false;
                            IsVoting = false;
                        }
                        else
                        {
                            Debug.Log("Tie for Players 1 and 2 _ Case 2");
                            int tieBreak = Random.Range(1, 3);
                            if (tieBreak == 1)
                            {
                                P1Enabled = false;
                                IsVoting = false;
                                Debug.Log("Tie Break = " + tieBreak);
                            }
                            else if (tieBreak == 2)
                            {
                                P2Enabled = false;
                                IsVoting = false;
                                Debug.Log("Tie Break = " + tieBreak);
                            }

                        }
                    }
                    break;

                case 3:
                    if (p1Voted && p2Voted && p3Voted)
                    {
                        int votedC3 = Mathf.Max(P1Vote, P2Vote, P3Vote);
                        if (votedC3 == P1Vote && votedC3 != P2Vote && votedC3 != P3Vote)
                        {
                            Debug.Log("Player 1 voted");
                            P1Enabled = false;
                            IsVoting = false;
                        }
                        else if (votedC3 == P2Vote && votedC3 != P1Vote && votedC3 != P3Vote)
                        {
                            Debug.Log("Player 2 voted");
                            P2Enabled = false;
                            IsVoting = false;
                        }
                        else if (votedC3 == P3Vote && votedC3 != P1Vote && votedC3 != P2Vote)
                        {
                            Debug.Log("Player 3 voted");
                            P3Enabled = false;
                            IsVoting = false;
                        }
                        else
                        {
                            switch (votedC3)
                            {
                                case 1:
                                    {
                                        Debug.Log("Tie between P1, P2 and P3");
                                        int tieBreak = Random.Range(1, 4);
                                        if (tieBreak == 1)
                                        {
                                            P1Enabled = false;
                                            IsVoting = false;
                                            Debug.Log("Tie Break = " + tieBreak);
                                        }
                                        if (tieBreak == 2)
                                        {
                                            P2Enabled = false;
                                            IsVoting = false;
                                            Debug.Log("Tie Break = " + tieBreak);
                                        }
                                        if (tieBreak == 3)
                                        {
                                            P3Enabled = false;
                                            IsVoting = false;
                                            Debug.Log("Tie Break = " + tieBreak);
                                        }
                                        break;
                                    }
                            }
                        }

                    }
                    break;

                case 4:
                    if (p1Voted && p2Voted && p3Voted && p4Voted)
                    {
                        int votedC4 = Mathf.Max(P1Vote, P2Vote, P3Vote, P4Vote);
                        if (votedC4 == P1Vote && votedC4 != P2Vote && votedC4 != P3Vote && votedC4 != P4Vote)
                        {
                            Debug.Log("Player 1 voted");
                            P1Enabled = false;
                            IsVoting = false;
                        }
                        else if (votedC4 == P2Vote && votedC4 != P1Vote && votedC4 != P3Vote && votedC4 != P4Vote)
                        {
                            Debug.Log("Player 2 voted");
                            P2Enabled = false;
                            IsVoting = false;
                        }
                        else if (votedC4 == P3Vote && votedC4 != P1Vote && votedC4 != P2Vote && votedC4 != P4Vote)
                        {
                            Debug.Log("Player 3 voted");
                            P3Enabled = false;
                            IsVoting = false;
                        }
                        else if (votedC4 == P4Vote && votedC4 != P1Vote && votedC4 != P2Vote && votedC4 != P3Vote)
                        {
                            Debug.Log("Player 4 voted");
                            P4Enabled = false;
                            IsVoting = false;
                        }
                        else
                        {
                            switch (votedC4)
                            {
                                case 1:
                                    {
                                        Debug.Log("Tie between P1, P2, P3 and P4");
                                        int tieBreak = Random.Range(1, 5);
                                        if (tieBreak == 1)
                                        {
                                            P1Enabled = false;
                                            IsVoting = false;
                                            Debug.Log("Tie Break = " + tieBreak);
                                        }
                                        if (tieBreak == 2)
                                        {
                                            P2Enabled = false;
                                            IsVoting = false;
                                            Debug.Log("Tie Break = " + tieBreak);
                                        }
                                        if (tieBreak == 3)
                                        {
                                            P3Enabled = false;
                                            IsVoting = false;
                                            Debug.Log("Tie Break = " + tieBreak);
                                        }
                                        if (tieBreak == 4)
                                        {
                                            P4Enabled = false;
                                            IsVoting = false;
                                            Debug.Log("Tie Break = " + tieBreak);
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        string tied1 = "";
                                        string tied2 = "";
                                        if (votedC4 == P1Vote)
                                        {
                                            tied1 = "P1";
                                        }
                                        if (votedC4 == P2Vote)
                                        {
                                            if (tied1 == "")
                                            {
                                                tied1 = "P2";
                                            }
                                            else
                                            {
                                                tied2 = "P2";
                                            }
                                        }
                                        if (votedC4 == P3Vote)
                                        {
                                            if (tied1 == "")
                                            {
                                                tied1 = "P3";
                                            }
                                            else
                                            {
                                                tied2 = "P3";
                                            }
                                        }
                                        if (votedC4 == P4Vote)
                                        {
                                            if (tied1 == "")
                                            {
                                                tied1 = "P4";
                                            }
                                            else
                                            {
                                                tied2 = "P4";
                                            }
                                        }
                                        Debug.Log("Tie between " + tied1 + ", " + tied2);
                                        int tieBreak = Random.Range(1, 3);
                                        if (tieBreak == 1)
                                        {
                                            if (tied1 == "P1")
                                            {
                                                P1Enabled = false;
                                                IsVoting = false;
                                            }
                                            else if (tied1 == "P2")
                                            {
                                                P2Enabled = false;
                                                IsVoting = false;
                                            }
                                            else if (tied1 == "P3")
                                            {
                                                P3Enabled = false;
                                                IsVoting = false;
                                            }
                                            else if (tied1 == "P4")
                                            {
                                                P4Enabled = false;
                                                IsVoting = false;
                                            }
                                            Debug.Log("Tie Break = " + tieBreak);
                                        }
                                        if (tieBreak == 2)
                                        {
                                            if (tied2 == "P1")
                                            {
                                                P1Enabled = false;
                                                IsVoting = false;
                                            }
                                            else if (tied2 == "P2")
                                            {
                                                P2Enabled = false;
                                                IsVoting = false;
                                            }
                                            else if (tied2 == "P3")
                                            {
                                                P3Enabled = false;
                                                IsVoting = false;
                                            }
                                            else if (tied2 == "P4")
                                            {
                                                P4Enabled = false;
                                                IsVoting = false;
                                            }
                                            Debug.Log("Tie Break = " + tieBreak);
                                        }
                                        break;
                                    }
                            }
                        }
                    }
                    break;
            }
        }
    }
    public void PlayerChecks()
    {
        if (!P1Enabled)
        {
            Player1.gameObject.GetComponent<Collider>().enabled = false;
            Player1.gameObject.GetComponent<Renderer>().enabled = false;
        }
        if (!P2Enabled)
        {
            Player2.gameObject.GetComponent<Collider>().enabled = false;
            Player2.gameObject.GetComponent<Renderer>().enabled = false;
        }
        if (!P3Enabled)
        {
            Player3.gameObject.GetComponent<Collider>().enabled = false;
            Player3.gameObject.GetComponent<Renderer>().enabled = false;
        }
        if (!P4Enabled)
        {
            Player4.gameObject.GetComponent<Collider>().enabled = false;
            Player4.gameObject.GetComponent<Renderer>().enabled = false;
        }

        if (P1Enabled)
        {
            Player1.gameObject.GetComponent<Collider>().enabled = true;
            Player1.gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (P2Enabled)
        {
            Player2.gameObject.GetComponent<Collider>().enabled = true;
            Player2.gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (P3Enabled)
        {
            Player3.gameObject.GetComponent<Collider>().enabled = true;
            Player3.gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (P4Enabled)
        {
            Player4.gameObject.GetComponent<Collider>().enabled = true;
            Player4.gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
}