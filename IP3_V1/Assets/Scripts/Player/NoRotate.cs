using UnityEngine;
using System.Collections;

public class NoRotate : MonoBehaviour {
    public Transform target;
    public float distance;
    public float height;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(target.position.x + distance, 0, target.position.z + height);
        //transform.position = new Vector3(target.position.x + distance, target.position.y + distance, target.position.z + height);
	}
}
