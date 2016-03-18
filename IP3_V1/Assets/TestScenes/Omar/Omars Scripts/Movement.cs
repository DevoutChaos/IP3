using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float speed;
    public Text scoreText;

    private Rigidbody rb;
    private int score;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreText();
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            //This can potentially set up 
            other.gameObject.SetActive(false);
            score++;
            SetScoreText();
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Player 1: " + score.ToString();
    } 
}