using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    //[SerializeField] allows variables to be edited in the Unity Editor freely
    [SerializeField] float steerSpeed = 300f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 35f;

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Bump") {
            Debug.Log("Bump Detected!!");
            moveSpeed = slowSpeed;
        }
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Boost") {
            Debug.Log("Boost Initiated!");
            moveSpeed = boostSpeed;
        }
    }
}
