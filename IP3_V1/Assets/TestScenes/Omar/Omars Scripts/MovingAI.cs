using UnityEngine;
using System.Collections;

public class MovingAI : MonoBehaviour {

    public float MinForce = 20f;
    public float MaxForce = 40f;
    private Rigidbody rb;
// Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        Push();
    }

// Update is called once per frame
    void Update () {

    }

    void Push()
    {
        float force = Random.Range(MinForce, MaxForce);
        float x = Random.Range(-1f, 1f);
        float z = Random.Range(-1f, 1f);

        rb.AddForce(force * new Vector3(x,z));
    }
}

