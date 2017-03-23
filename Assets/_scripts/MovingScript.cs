using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    private float movementZ;
    private float movementX;
    private Vector3 direction;

    // Use this for initialization
    void Start()
    {
        movementZ = Random.Range(0.1f, 0.5f);
        movementX = Random.Range(0.1f, 0.5f);
        direction = new Vector3(movementX, 0, movementZ);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.position = transform.position + direction;

    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Walls"))
        {
            movementZ = -movementZ;
            movementX = -movementX;
            direction = new Vector3(movementX, 0,movementZ);
        }
    }
}
