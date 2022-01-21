using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D girl;

    public float speed;
    public RandomCandy controller;





    void Start()
    {
        girl = GetComponent<Rigidbody2D>();


    }


    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        if (h > 0)

            girl.velocity = Vector2.right * speed;

        else if (h < 0)

            girl.velocity = Vector2.left * speed;

        else
            girl.velocity = Vector2.zero;

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        var bad = col.transform.GetComponent<Leave>().bad;

        if (!bad)
        {
            controller.myScore += 10;
        }
        else
        {
            controller.myScore -= 5;
        }
        Destroy(col.gameObject);
    }
}