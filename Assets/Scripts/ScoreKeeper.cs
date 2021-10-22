using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private TextMeshProUGUI highScoreText;
    public int scoreValue;
    public int highScoreValue;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

        highScoreText = GameObject.Find("HighScoreText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreValue > highScoreValue)
        {
            highScoreValue = scoreValue;
            highScoreText.text = "High: " + highScoreValue.ToString();
        }
    }

    public void UpdateScore()
    {
        scoreValue += 5;
        scoreText.text = "Score: " + scoreValue.ToString();
    }

    public void ClearScore()
    {
        scoreValue = 0;
        scoreText.text = "Score: " + scoreValue.ToString();
    }
}
