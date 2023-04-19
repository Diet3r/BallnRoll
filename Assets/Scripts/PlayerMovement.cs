using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    GameObject Maincamera;

    float rollSpeed = 70f;
    public float maxRollSpeed = 9f;

    float xAxis;
    float zAxis;
    Vector3 oldPosition = new Vector3();
    Vector3 cameraAxis;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Maincamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        //MovementForce();
        //Geschwindigkeitsbegrenzer();
    }

    private void FixedUpdate()
    {
        MovementForce();
        //Geschwindigkeitsbegrenzer();
    }

    void MovementForce()
    {
        xAxis = Input.GetAxis("Horizontal");
        //cameraAxis = Maincamera.transform.TransformDirection(1, 0, 1);
        zAxis = Input.GetAxis("Vertical");
        Vector3 newPosition = rb.position;
        Debug.Log("x: " + Mathf.Abs(newPosition.x - oldPosition.x) + "   z: " + Mathf.Abs(newPosition.z - oldPosition.z));


        if (rb.velocity.x >= 0)
        {
            if (xAxis > 0)
            {
                if (Mathf.Abs(newPosition.x - oldPosition.x) <= maxRollSpeed * Time.deltaTime)
                {
                    rb.AddForce(xAxis * rollSpeed, 0, 0);
                }
            }
            else if (xAxis < 0)
            {
                rb.AddForce(xAxis * rollSpeed, 0, 0);
            }
        }
        if (rb.velocity.x <= 0)
        {
            if (xAxis < 0)
            {
                if (Mathf.Abs(newPosition.x - oldPosition.x) <= maxRollSpeed * Time.deltaTime)
                {
                    rb.AddForce(xAxis * rollSpeed, 0, 0);
                }
            }
            else if (xAxis > 0)
            {
                rb.AddForce(xAxis * rollSpeed, 0, 0);
            }
        }

        if (rb.velocity.z >= 0)
        {
            if (zAxis > 0)
            {
                if (Mathf.Abs(newPosition.z - oldPosition.z) <= maxRollSpeed * Time.deltaTime)
                {
                    rb.AddForce(0, 0, zAxis * rollSpeed);
                }
            }
            else if (zAxis < 0)
            {
                rb.AddForce(0, 0, zAxis * rollSpeed);
            }
        }
        else if (rb.velocity.z <= 0)
        {
            if (zAxis < 0)
            {
                if (Mathf.Abs(newPosition.z - oldPosition.z) <= maxRollSpeed * Time.deltaTime)
                {
                    rb.AddForce(0, 0, zAxis * rollSpeed);
                }
            }
            else if (zAxis > 0)
            {
                rb.AddForce(0, 0, zAxis * rollSpeed);
            }
        }

        oldPosition = newPosition;

        //rb.AddForce(xAxis * cameraAxis.x * rollSpeed, 0, zAxis * cameraAxis.z * rollSpeed);
        //rb.AddForce(xAxis * rollSpeed, 0, zAxis * rollSpeed);
        //mathf.abs
    }

    void Geschwindigkeitsbegrenzer()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxRollSpeed);
    }
}
