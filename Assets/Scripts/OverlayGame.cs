using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OverlayGame : MonoBehaviour
{
    GameManager manager;
    [SerializeField] TextMeshProUGUI textTimer;

    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        textTimer.text = "Time: " + manager.GetTimer().ToString("F2") + "s";
    }
}
