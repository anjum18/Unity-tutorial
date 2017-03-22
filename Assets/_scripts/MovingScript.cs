using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        transform.Translate(new Vector3(5, 0, 5) * Time.deltaTime);
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("rersdf");
        if (other.gameObject.CompareTag("Wall"))
        {
            
            gameObject.SetActive(false);
        }
    }
}
