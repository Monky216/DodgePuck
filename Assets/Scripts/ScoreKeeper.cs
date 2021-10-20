using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private TextMeshProUGUI highScoreText;
    public int scoreValue;
    private int highScoreValue;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        scoreValue += 5;
        //DOES NOT LIKE 29!!!
        scoreText.text = ("Score: " + scoreValue);
    }

    public void ClearScore()
    {
        scoreValue = 0;
        //DOES NOT LIKE 36!!!
        scoreText.text = ("Score: " + scoreValue);
    }
}
