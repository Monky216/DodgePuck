using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public GameObject InvertedPuck;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    //if hit by special puck, invert controls for set time
    private void OnTriggerEnter2D(Collider2D welp)
    {
        if (welp.gameObject.CompareTag("InvertdPuck"))
        {
            //physical I-puck
            Debug.Log("uh oh spaghetti o's");
            //generate I-puck here?

            //after time, continue normal controls
        }
    }
}
