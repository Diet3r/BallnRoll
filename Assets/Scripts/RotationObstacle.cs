using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObstacle : MonoBehaviour
{
    [Range(36,360)]
    public float rotationSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateObject();
    }

    //rotate object on y axis with rotationSpeed
    void RotateObject()
    {
        transform.Rotate(0, 0, 1 * rotationSpeed * Time.deltaTime);
    }
}
