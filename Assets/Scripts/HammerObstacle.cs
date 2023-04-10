using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HammerObstacle : MonoBehaviour
{
    [Range(90, 200)]
    public float rotationMaximum;

    [Range(50, 150)]
    public float rotationSpeed = 10f;

    bool isRotationSide = false;

    float rotationAngle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //HammerTime();
        MCHammer();
    }

    void HammerTime()
    {      
        if (!isRotationSide)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y, -1 * rotationSpeed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y, rotationSpeed * Time.deltaTime);
        }

        if (isRotationSide && transform.rotation.z > -rotationMaximum) 
        {
            isRotationSide = false;
        }
        if (!isRotationSide && transform.rotation.z < rotationMaximum) 
        {
        }
    }

    //use mathf.pingpon for rotation between two points
    void MCHammer()
    {
        rotationAngle = Mathf.PingPong(Time.time * rotationSpeed, rotationMaximum) - (0.5f * rotationMaximum);
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, rotationAngle);
    }
}
