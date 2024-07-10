using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Fast Food (For the Mob) (The Crime One): " + score.ToString();
    }

    // Update is called once per frame
    public void AddScore()
    {
        score++;
        scoreText.text = "Food (For the Mob) (The Crime One): " + score.ToString();
    }

    public void RemoveScore()
    {
        if (score > 0)
        {
            score--;
            scoreText.text = "Fast Food (For the Mob) (The Crime One): " + score.ToString();
        }
    }
}
