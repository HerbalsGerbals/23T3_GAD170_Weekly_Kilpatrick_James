using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject cube;
    public SimplePlayerController controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Controller"))
        {
            Debug.Log("Trigger Code Works");
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 204, 102);
        }
    }
}
