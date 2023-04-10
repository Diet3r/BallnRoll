using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerHead : MonoBehaviour
{
    [Range(90, 200)]
    float forcePower = 100f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector3 direction = collision.contacts[0].point - transform.position;
            Debug.Log("Dir: " + direction);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(direction * forcePower, ForceMode.Impulse) ;
        }
    }
}
