
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;         // Speed of the player
    private float turnSpeed = 45.0f;     // Turning speed of the player
    private float horizontalInput;        // Input for horizontal movement
    private float forwardInput;           // Input for forward movement

    void Update()
    {
        // Get input from the user
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the player forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotate the player based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
