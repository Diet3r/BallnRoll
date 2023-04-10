using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    float rollSpeed;
    public float maxRollSpeed = 9f;

    float xAxis;
    float zAxis;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        Geschwindigkeitsbegrenzer();
    }

    void MovementForce()
    {
        xAxis = Input.GetAxis("Horizontal");
        zAxis = Input.GetAxis("Vertical");

        //if (xAxis != 0 || zAxis != 0)
        //{
        //    rollSpeed += 0.1f;
        //    if (rollSpeed > maxRollSpeed)
        //    {
        //        rollSpeed = maxRollSpeed;
        //    }
        //}
        //else
        //{
        //    rollSpeed -= 0.1f;
        //    if (rollSpeed < 0)
        //    {
        //        rollSpeed = 0;
        //    }
        //}
        rollSpeed = 70f;
        rb.AddForce(xAxis * rollSpeed, 0, zAxis * rollSpeed);
    }

    void Geschwindigkeitsbegrenzer()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxRollSpeed);
    }
}
