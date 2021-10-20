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
    public GameObject gameOverText;

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

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Blocky"))
        {
            //level 2!
            Destroy(other.gameObject);
            Instantiate(Blocky, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);
            Instantiate(Puck, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);

            //Score DOES NOT LIKE 41!!!
            scoreText.GetComponent<ScoreKeeper>().UpdateScore();
        }

        if (other.gameObject.CompareTag("Puck"))
        {
            //Game Over
            gameOverText.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void NewGame()
    {
        //death to pucks
        GameObject[] allPucks = GameObject.FindGameObjectsWithTag("Puck");
        foreach (GameObject death in allPucks)
            GameObject.Destroy(death);

        //death to blockys
        GameObject[] allBlockys = GameObject.FindGameObjectsWithTag("Blocky");
        foreach (GameObject death in allBlockys)
            GameObject.Destroy(death);

        //reset position
        transform.position = new Vector2(0, 0);

        //reset gameojects
        Instantiate(Blocky, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);
        Instantiate(Puck, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);

        //reset scene
        Time.timeScale = 1;
        gameOverText.SetActive(false);
        //DOES MOT LIKE 75!!!
        scoreText.GetComponent<ScoreKeeper>().ClearScore();
    }
}
