using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    GameObject player;

    float turnSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            float delta = Input.GetAxis("Mouse X") * turnSpeed;
            transform.RotateAround(player.transform.position, Vector3.up, delta);
            Debug.Log(delta);
        }
    }
    //{
    //if(Input.GetMouseDown(0))
    //{
    //    float delta = Input.GetAxis("Mouse X") * turnSpeed;
    //transform.RotateAround(player.position, Vector3.up, delta);
    //}
}
