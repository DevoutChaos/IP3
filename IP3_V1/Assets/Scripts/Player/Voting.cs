using UnityEngine;
using System.Collections;

public class Voting : MonoBehaviour
{

    //Declarations
    public bool IsVoting;
    int noOfPlayers;
    int P1Vote;
    int P2Vote;
    int P3Vote;
    int P4Vote;

    public bool p1Voted;
    public bool p2Voted;
    public bool p3Voted;
    public bool p4Voted;

    // Use this for initialization
    void Start()
    {
        p1Voted = false;
        p2Voted = false;
        p3Voted = false;
        p4Voted = false;

        //Check apparent number of players.
        noOfPlayers = Input.GetJoystickNames().Length;
        Debug.Log("Players present: " + noOfPlayers);
    }

    // Update is called once per frame
    void Update()
    {
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
                        }
                        else if (P2Vote > P1Vote)
                        {
                            Debug.Log("Player 2 voted _ Case 2");
                        }
                        else
                        {
                            Debug.Log("Tie for Players 1 and 2 _ Case 2");
                        }
                    }
                    break;

                case 3:
                    if (p1Voted && p2Voted && p3Voted)
                    {
                        //***KNOWN ISSUE - IN EVENT OF A DRAW, WILL ALWAYS RETURN PLAYER WHO IS LOWEST NUMERICALLY. ***//
                        //***COULD FIX BY USING [&& votedC3 !=] ***// 
                        int votedC3 = Mathf.Max(P1Vote, P2Vote, P3Vote);
                        if (votedC3 == P1Vote)
                        {
                            Debug.Log("Player 1 voted");
                        }
                        else if (votedC3 == P2Vote)
                        {
                            Debug.Log("Player 2 voted");
                        }
                        else if (votedC3 == P3Vote)
                        {
                            Debug.Log("Player 3 voted");
                        }
                        else
                        {
                            Debug.Log("Tie");
                        }

                    }
                    break;

                case 4:
                    if (p1Voted && p2Voted && p3Voted && p4Voted)
                    {
                        //***KNOWN ISSUE - IN EVENT OF A DRAW, WILL ALWAYS RETURN PLAYER WHO IS LOWEST NUMERICALLY. ***//
                        //***COULD FIX BY USING [&& votedC4 !=] ***// 
                        int votedC4 = Mathf.Max(P1Vote, P2Vote, P3Vote, P4Vote);
                        if (votedC4 == P1Vote)
                        {
                            Debug.Log("Player 1 voted");
                        }
                        else if (votedC4 == P2Vote)
                        {
                            Debug.Log("Player 2 voted");
                        }
                        else if (votedC4 == P3Vote)
                        {
                            Debug.Log("Player 3 voted");
                        }
                        else if (votedC4 == P4Vote)
                        {
                            Debug.Log("Player 4 voted");
                        }
                        else
                        {
                            Debug.Log("Tie");
                        }
                    }
                    break;
            }
        }
    }
}