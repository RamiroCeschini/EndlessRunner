using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float scoreNumber;
    public float scoreSuma;

    // Start is called before the first frame update
    void Start()
    {
        scoreNumber = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + (int)scoreNumber;
        scoreNumber += scoreSuma * Time.deltaTime;
    }
}
