using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    
    [SerializeField] float rocketForce;
    [SerializeField] float rocketRotateForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    void ProcessInput ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.up * rocketForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rocketRotateForce);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rocketRotateForce);
        }
    }

    void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
