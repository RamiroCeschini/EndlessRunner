using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstáculo : MonoBehaviour

{
    public float obstacleSpeed = -2f;

    void Update()
    {

            transform.Translate(obstacleSpeed * Time.deltaTime, 0f, 0f);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TriggerObs")
        {
           Destroy(gameObject);
        }
    }
}
