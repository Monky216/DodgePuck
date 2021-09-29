using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckController : MonoBehaviour
{
    public int[] direction = { 0, 1, 2, 3 };
    public int moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = direction[2];
        Debug.Log("moveDirection = " + moveDirection);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
