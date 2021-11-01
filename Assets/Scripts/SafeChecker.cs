using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeChecker : MonoBehaviour
{
    public GameObject safeZone;
    public GameObject puck;
    public float xRange;
    public float yRange;

    public void OnTriggerEnter2D(Collider2D what)
    {
        if (what.gameObject.CompareTag("Player"))
        {
            //destory SafeZones and try again
            Instantiate(safeZone, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);

            Debug.Log("reverse!");
        }

        else
        {
            //Instantiate(Puck, new Vector2(where SafeZone is);
            //destory all SafeZones

            Debug.Log("spawn here");
        }
    }
}
