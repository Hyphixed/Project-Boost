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
            RotateLeft();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            RotateRight();
        }
    }

    void RotateRight()
    {
        transform.Rotate(new Vector3(0, 0, -rocketRotateForce * Time.deltaTime));
    }

    void RotateLeft()
    {
        transform.Rotate(new Vector3(0, 0, rocketRotateForce * Time.deltaTime));
    }
}
