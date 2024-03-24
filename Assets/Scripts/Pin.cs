using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool _done;

    public static int point;

    protected void OnCollisionEnter(Collision collision)
    {
        if ((collision.collider.CompareTag("Ball") || collision.collider.CompareTag("Pin")) && !_done)
        {
            // get the velocity of the pin after the collision
            float velocity = GetComponent<Rigidbody>().velocity.magnitude;

            // check if the velocity has dropped below the fall threshold
            if (velocity < 10)
            {
                int point = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>().Point;
                point += 1;
                GameObject.FindGameObjectWithTag("Poing").GetComponent<TextMeshProUGUI>().text = $"Score : {point}";
                GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>().Point = point;
                _done = true;
            }


        }
    }

}
