using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour {

    public GameObject[] food;
    public int amount;
    private Vector3 spawnPoint;
    //public GameObject startFood;
	// Use this for initialization
	void Start () {
        //Instantiate(startFood, new Vector3(5, 2.32f, 4), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {

        food = GameObject.FindGameObjectsWithTag("Food");
        amount = food.Length;

        if (amount != 3)
        {
            InvokeRepeating("spawnFood", 1f, 10f);
        }
	}

    void spawnFood()
    {
        spawnPoint.x = Random.Range (480, 520);
        spawnPoint.y = 2.32f;
        spawnPoint.z = Random.Range (480, 520);

        Instantiate(food[UnityEngine.Random.Range(0, food.Length)], spawnPoint, Quaternion.identity);
        CancelInvoke();
    }
}
