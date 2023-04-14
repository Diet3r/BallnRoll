using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    GameObject camera;

    float rollSpeed = 70f;
    public float maxRollSpeed = 9f;

    float xAxis;
    float zAxis;
    Vector3 cameraAxis;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camera = GameObject.FindGameObjectWithTag("MainCamera");
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
        cameraAxis = camera.transform.TransformDirection(1, 0, 1);
        zAxis = Input.GetAxis("Vertical");


        rb.AddForce(xAxis * cameraAxis.x * rollSpeed, 0, zAxis * cameraAxis.z * rollSpeed);
    }

    void Geschwindigkeitsbegrenzer()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxRollSpeed);
    }
}
