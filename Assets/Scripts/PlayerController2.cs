using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed;
    public float xRange;
    public float yRange;
    public GameObject Puck;
    public GameObject Blocky;
    public GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //Puck spawner
        Instantiate(Puck, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);

        //Blocky Spawner
        Instantiate(Blocky, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        //Puck spawner
        Instantiate(Puck, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);

        //How many Pucks are on screen
        GameObject[] puckArray;
            puckArray = GameObject.FindGameObjectsWithTag("Puck");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Blocky"))
        {
            Destroy(other.gameObject);
            Instantiate(Blocky, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);

            //Score
            scoreText.GetComponent<ScoreKeeper>().UpdateScore();
        }
    }

}
