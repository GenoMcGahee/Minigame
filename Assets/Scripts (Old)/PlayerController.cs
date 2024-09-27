using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 13;
    public float yRange = 6;
    public GameObject arrowPrefab;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.y < 1)
        {
            transform.position = new Vector3(1, transform.position.z, transform.position.x);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(yRange, transform.position.z, transform.position.x);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(arrowPrefab, transform.position, arrowPrefab.transform.rotation);
        }
    }
}
