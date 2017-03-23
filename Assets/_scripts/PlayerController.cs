using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpSpeed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetKeyDown("space")) {
            jump();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            Destroy(other.gameObject);
            count++;
            setCountText();
            if (count >= 4)
            {
                winText.text = "You Win!";
            }


        }
    }

    private void setCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

    private void jump()
    {

        Debug.Log("test");
        Vector3 movement = new Vector3(0.0f, 10.5f, 0.0f);

        rb.AddForce(movement * jumpSpeed);
    }

}