﻿using UnityEngine;
using System.Collections;

public class MovingFood : MonoBehaviour
{

    private bool dirRight = true;
    public float speed = 2.0f;

    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 506.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= 494.0f)
        {
            dirRight = true;
        }
    }

}