using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody rigidbody;
    public float movement;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Trigger Box to the left");
        Debug.Log("Giant Capsule is for collision");
        Debug.Log("The Cube and Sphere were original jump testers");
        jumpForce = 10;
        movement = 150;
    }
    // Update is called once per frame
    void Update()
    {
        Rigidbody ridgidbody = GetComponent<Rigidbody>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            ridgidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.W))
        {
            ridgidbody.AddForce(Vector3.forward * movement * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            ridgidbody.AddForce(Vector3.back * movement * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            ridgidbody.AddForce(Vector3.right * movement * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            ridgidbody.AddForce(Vector3.left * movement * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Controller"))
        {
            Debug.Log("Collison Code works");
        }
    }
}
