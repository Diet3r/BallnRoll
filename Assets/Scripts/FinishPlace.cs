using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPlace : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.StopTimer();
            gameManager.GameWon();
        }
    }
}
