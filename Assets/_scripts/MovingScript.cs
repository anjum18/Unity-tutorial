using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.position = transform.position + new Vector3(0, 0, 0.5f);

    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Walls"))
        {
            Debug.Log("rersdf");
            gameObject.SetActive(false);
        }
    }
}
