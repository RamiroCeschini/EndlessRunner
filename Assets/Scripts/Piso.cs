using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour
{
    public float floorSpeed = -2f;
    
    
    void Update()
    {
        transform.Translate(floorSpeed * Time.deltaTime,0f,0f);

        if (transform.position.x <= -21.22)
        {
            transform.position = new Vector3(42.44f, transform.position.y, 0f);
        }
    }
}
