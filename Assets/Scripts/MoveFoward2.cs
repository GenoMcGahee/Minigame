using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    public float speed = 10.0f;
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}

