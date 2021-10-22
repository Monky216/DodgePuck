using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public GameObject SafeZone;

    // Start is called before the first frame update
    void Start()
    {
        //should I set up that SafeZone as a child and how it works here? Give it a little instrustion on how to live its life?
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D safe)
    {
        Instantiate(SafeZone, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);

        if (safe.gameObject.CompareTag("Player"))
        {
            GameObject[] allSafeZones = GameObject.FindGameObjectsWithTag("SafeZone");
            foreach (GameObject death in allSafeZones)
                GameObject.Destroy(death);
            //go back!

            Debug.Log("Haha boogity!");
        }

        else if (!safe.gameObject.CompareTag("Player"))
        {
            //Instantiate(Puck, new Vector2(where ever SafeZone is);
        }
    }
}
