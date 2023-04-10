using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    OverlayManager overlayManager;

    float timer = 0;
    bool isTimer = false;

    bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        overlayManager = FindObjectOfType<OverlayManager>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer += GetTime();
        PauseGame();
    }

    public void StartTimer()
    {
        isTimer = true;
    }

    public void StopTimer()
    {
        isTimer = false;
    }

    float GetTime()
    {
        if (isTimer)
        {
            return Time.deltaTime;
        }
        else
        {
            return 0;
        }        
    }     

    public float GetTimer()
    {
        return timer;
    }

    void PauseGame()
    {
        if (Input.GetButtonDown("Jump") && !isPaused)
        {
            Time.timeScale = 0;
            overlayManager.ShowOverlayPause();
            isPaused = true;
        }
        else if (Input.GetButtonDown("Jump") && isPaused)
        {
            overlayManager.ShowOverlayGame();
            Time.timeScale = 1;
            isPaused = false;
        }
    }

    public void UnPauseGame()
    {
        overlayManager.ShowOverlayGame();
        Time.timeScale = 1;
        isPaused = false;
    }

    public void GameOver()
    {
        overlayManager.ShowOverlayFailed();
        Time.timeScale = 0;
    }

    public void GameWon()
    {
        overlayManager.ShowOverlayFinish();
        Time.timeScale = 0;
    }
}
