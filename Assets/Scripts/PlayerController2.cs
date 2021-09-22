using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed;
    public float xRange;
    public float yRange;
    public GameObject Puck;

    // Start is called before the first frame update
    void Start()
    {
        //Move to void Update later
        //Puck spawner
        Instantiate(Puck, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        //How many Pucks are on screen
        GameObject[] puckArray;
        puckArray = GameObject.FindGameObjectsWithTag("Puck");
        Debug.Log("Puck Count: " + puckArray.Length);
    }
}
