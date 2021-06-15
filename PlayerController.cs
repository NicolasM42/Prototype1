using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputID;

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;

    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Assing to user inputs
        horizontalInput = Input.GetAxis("Horizontal " + inputID);
        verticalInput = Input.GetAxis("Vertical " + inputID);

        // Car Movement Code
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
