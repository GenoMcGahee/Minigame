using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private float topBound = 15;
    private float lowerBound = -15;

    void Update()
    {
        if (transform.position.x > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < lowerBound)
        {
            Debug.Log("git gud bruh");
            Destroy(gameObject);
            Application.Quit();
        }
       
        

    }
}
