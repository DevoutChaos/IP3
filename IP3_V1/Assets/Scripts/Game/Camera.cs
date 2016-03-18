using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{

    public Transform player1;
    public Transform player2;
    public Transform player3;
    public Transform player4;

    public float averageX;
    public float averageY;
    public float averageZ;
    public float maxX;
    public float maxY;
    public float maxZ;

    public Voting voting;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (voting.noOfPlayers == 4)
        {
            if (voting.P1Enabled == false)
            {
                averageX = (player4.position.x + player2.position.x + player3.position.x) / 3;
                averageY = (player4.position.y + player2.position.y + player3.position.y) / 3;
                averageZ = (player4.position.z + player2.position.z + player3.position.z) / 3;
                maxX = Mathf.Max(player4.position.x, player2.position.x, player3.position.x);
                maxY = Mathf.Max(player4.position.y, player2.position.y, player3.position.y);
                maxZ = Mathf.Max(player4.position.z, player2.position.z, player3.position.z);
            }
            else if (voting.P2Enabled == false)
            {
                averageX = (player1.position.x + player4.position.x + player3.position.x) / 3;
                averageY = (player1.position.y + player4.position.y + player3.position.y) / 3;
                averageZ = (player1.position.z + player4.position.z + player3.position.z) / 3;
                maxX = Mathf.Max(player4.position.x, player1.position.x, player3.position.x);
                maxY = Mathf.Max(player4.position.y, player1.position.y, player3.position.y);
                maxZ = Mathf.Max(player4.position.z, player1.position.z, player3.position.z);
            }
            else if (voting.P3Enabled == false)
            {
                averageX = (player1.position.x + player2.position.x + player4.position.x) / 3;
                averageY = (player1.position.y + player2.position.y + player4.position.y) / 3;
                averageZ = (player1.position.z + player2.position.z + player4.position.z) / 3;
                maxX = Mathf.Max(player4.position.x, player2.position.x, player1.position.x);
                maxY = Mathf.Max(player4.position.y, player2.position.y, player1.position.y);
                maxZ = Mathf.Max(player4.position.z, player2.position.z, player1.position.z);
            }
            else if (voting.P4Enabled == false)
            {
                averageX = (player1.position.x + player2.position.x + player3.position.x) / 3;
                averageY = (player1.position.y + player2.position.y + player3.position.y) / 3;
                averageZ = (player1.position.z + player2.position.z + player3.position.z) / 3;
                maxX = Mathf.Max(player1.position.x, player2.position.x, player3.position.x);
                maxY = Mathf.Max(player1.position.y, player2.position.y, player3.position.y);
                maxZ = Mathf.Max(player1.position.z, player2.position.z, player3.position.z);
            }
            else
            {
                averageX = (player1.position.x + player2.position.x + player3.position.x + player4.position.x) / 4;
                averageY = (player1.position.y + player2.position.y + player3.position.y + player4.position.y) / 4;
                averageZ = (player1.position.z + player2.position.z + player3.position.z + player4.position.z) / 4;
                maxX = Mathf.Max(player4.position.x, player2.position.x, player3.position.x, player1.position.x);
                maxY = Mathf.Max(player4.position.y, player2.position.y, player3.position.y, player1.position.y);
                maxZ = Mathf.Max(player4.position.z, player2.position.z, player3.position.z, player1.position.z);
            }
        }
        else if (voting.noOfPlayers == 3)
        {
            if (voting.P1Enabled == false)
            {
                averageX = (player2.position.x + player3.position.x) / 2;
                averageY = (player2.position.y + player3.position.y) / 2;
                averageZ = (player2.position.z + player3.position.z) / 2;
                maxX = Mathf.Max(player2.position.x, player3.position.x);
                maxY = Mathf.Max(player2.position.y, player3.position.y);
                maxZ = Mathf.Max(player2.position.z, player3.position.z);
            }
            if (voting.P2Enabled == false)
            {
                averageX = (player1.position.x + player3.position.x) / 2;
                averageY = (player1.position.y + player3.position.y) / 2;
                averageZ = (player1.position.z + player3.position.z) / 2;
                maxX = Mathf.Max(player1.position.x, player3.position.x);
                maxY = Mathf.Max(player1.position.y, player3.position.y);
                maxZ = Mathf.Max(player1.position.z, player3.position.z);
            }
            if (voting.P3Enabled == false)
            {
                averageX = (player1.position.x + player2.position.x) / 2;
                averageY = (player1.position.y + player2.position.y) / 2;
                averageZ = (player1.position.z + player2.position.z) / 2;
                maxX = Mathf.Max(player1.position.x, player2.position.x);
                maxY = Mathf.Max(player1.position.y, player2.position.y);
                maxZ = Mathf.Max(player1.position.z, player2.position.z);
            }
            else
            {
                averageX = (player1.position.x + player2.position.x + player3.position.x) / 3;
                averageY = (player1.position.y + player2.position.y + player3.position.y) / 3;
                averageZ = (player1.position.z + player2.position.z + player3.position.z) / 3;
                maxX = Mathf.Max(player1.position.x, player2.position.x, player3.position.x);
                maxY = Mathf.Max(player1.position.y, player2.position.y, player3.position.y);
                maxZ = Mathf.Max(player1.position.z, player2.position.z, player3.position.z);
            }

        }
        else if (voting.noOfPlayers == 2)
        {
            if (voting.P1Enabled == false)
            {
                averageX = (player2.position.x) / 1;
                averageY = (player2.position.y) / 1;
                averageZ = (player2.position.z) / 1;
                maxX = Mathf.Max(player2.position.x);
                maxY = Mathf.Max(player2.position.y);
                maxZ = Mathf.Max(player2.position.z);
            }
            else if (voting.P2Enabled == false)
            {
                averageX = (player1.position.x) / 1;
                averageY = (player1.position.y) / 1;
                averageZ = (player1.position.z) / 1;
                maxX = Mathf.Max(player1.position.x);
                maxY = Mathf.Max(player1.position.y);
                maxZ = Mathf.Max(player1.position.z);
            }
            else
            {
                averageX = (player1.position.x + player2.position.x) / 2;
                averageY = (player1.position.y + player2.position.y) / 2;
                averageZ = (player1.position.z + player2.position.z) / 2;
                maxX = Mathf.Max(player1.position.x, player2.position.x);
                maxY = Mathf.Max(player1.position.y, player2.position.y);
                maxZ = Mathf.Max(player1.position.z, player2.position.z);
            }
        }
        else if (voting.noOfPlayers == 1)
        {
            averageX = (player1.position.x) / 1;
            averageY = (player1.position.y) / 1;
            averageZ = (player1.position.z) / 1;
            maxX = Mathf.Max(player1.position.x);
            maxY = Mathf.Max(player1.position.y);
            maxZ = Mathf.Max(player1.position.z);
        }
        averageY = (((maxX + 3) - transform.position.x) + ((maxZ + 3) - transform.position.z));
        if (averageY >= 60)
        {
            averageY = 50;
        }
        transform.position = new Vector3(averageX, averageY, averageZ);
    }
}