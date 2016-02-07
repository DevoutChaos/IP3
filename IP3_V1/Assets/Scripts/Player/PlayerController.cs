using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    //General Declarations
    public float speed = 1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horMove1 = Input.GetAxis("Horizontal_P1");
        float verMove1 = Input.GetAxis("Vertical_P1");
        if (this.gameObject.tag == "Player1")
        {
            Debug.Log("Horizontal: " + horMove1 + ", Vertical: " + verMove1);
            GetComponent<Rigidbody>().velocity = new Vector3(horMove1 * speed,0, verMove1 * speed);
        }

        if (this.tag == "Player2")
        {
            float horMove = Input.GetAxis("Horizontal_P2");
            float verMove = Input.GetAxis("Vertical_P2");
            GetComponent<Rigidbody>().velocity = new Vector3(horMove * speed, verMove * speed);
        }

        if (this.tag == "Player3")
        {
            float horMove = Input.GetAxis("Horizontal_P3");
            float verMove = Input.GetAxis("Vertical_P3");
            GetComponent<Rigidbody>().velocity = new Vector3(horMove * speed, verMove * speed);
        }

        if (this.tag == "Player4")
        {
            float horMove = Input.GetAxis("Horizontal_P4");
            float verMove = Input.GetAxis("Vertical_P4");
            GetComponent<Rigidbody>().velocity = new Vector3(horMove * speed, verMove * speed);
        }

    }
}
