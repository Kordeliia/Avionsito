using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public static PlayerControllerX sharedInstance;
    public float speed;
    public float rotationSpeed;
    public float horizontalInput;
    public float verticalInput;

    private void Awake()
    {
        sharedInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(speed * Time.deltaTime * Vector3.forward);
        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);

        //tilt the plane up/down based on up/down arrow Keys
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * horizontalInput);

    }
}
