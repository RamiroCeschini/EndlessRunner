using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text scoretext;
    public GameObject Score;
    private Score ScoreCount;
    public int finalScore;

    void Start()
    {
       ScoreCount = Score.gameObject.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        finalScore = (int)ScoreCount.scoreNumber;
        scoretext.text = "Score: " + finalScore;
    }
}
