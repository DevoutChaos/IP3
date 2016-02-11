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
        transform.position = new Vector3(target.position.x, target.position.y + height, target.position.z - distance);
	}
}
