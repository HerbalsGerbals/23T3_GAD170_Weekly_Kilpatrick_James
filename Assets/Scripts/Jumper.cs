using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody jumpTest;
    public float jumpForce;
    public GameObject cube;
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody jumpTest = GetComponent<Rigidbody>();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jumpForce = 10;
            jumpTest.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.J))
        {
            jumpForce = 50;
            jumpTest.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
