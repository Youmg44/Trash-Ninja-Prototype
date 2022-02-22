using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoremanager : MonoBehaviour
{
    public static scoremanager instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
    }

    void Update()
    {

    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
    }
}
