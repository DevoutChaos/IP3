using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    //General Declarations
    public float speed = 1f;
    public Text scoreText;
    private int score;
    public Voting voting;

    // Use this for initialization
    void Start()
    {
        score = 0;
        SetScoreText();

        //Player1 = GameObject.FindGameObjectWithTag("Player1");
        //Player2 = GameObject.FindGameObjectWithTag("Player2");
        //Player3 = GameObject.FindGameObjectWithTag("Player3");
        //Player4 = GameObject.FindGameObjectWithTag("Player4");
    }

    void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (this.gameObject.tag == "Player1" && voting.P1Enabled)
        {
            float horMove1 = Input.GetAxis("Horizontal_P1");
            float verMove1 = Input.GetAxis("Vertical_P1");
            GetComponent<Rigidbody>().velocity = new Vector3(horMove1 * speed, 0, verMove1 * speed);
        }

        if (this.gameObject.tag == "Player2" && voting.P2Enabled)
        {
            float horMove2 = Input.GetAxis("Horizontal_P2");
            float verMove2 = Input.GetAxis("Vertical_P2");
            GetComponent<Rigidbody>().velocity = new Vector3(horMove2 * speed, 0, verMove2 * speed);
        }

        if (this.gameObject.tag == "Player3" && voting.P3Enabled)
        {
            float horMove3 = Input.GetAxis("Horizontal_P3");
            float verMove3 = Input.GetAxis("Vertical_P3");
            GetComponent<Rigidbody>().velocity = new Vector3(horMove3 * speed, 0, verMove3 * speed);
        }

        if (this.gameObject.tag == "Player4" && voting.P4Enabled)
        {
            float horMove4 = Input.GetAxis("Horizontal_P4");
            float verMove4 = Input.GetAxis("Vertical_P4");
            GetComponent<Rigidbody>().velocity = new Vector3(horMove4 * speed, 0, verMove4 * speed);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            other.gameObject.SetActive(false);
            score++;
            SetScoreText();
        }
    }
    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
