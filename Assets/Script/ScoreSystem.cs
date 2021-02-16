using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public int score = 0;
    public float netTime = 1f;
    float time;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        time = netTime;
    }
    void AddScore(int points)
    {
        score += points;
    }
    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
        if (time < 0)
        {
            time = netTime;
            AddScore(1);
            scoreText.SetText(score.ToString());
        }
    }
}
