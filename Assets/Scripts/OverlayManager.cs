using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayManager : MonoBehaviour
{
    [SerializeField] GameObject overlayGame;
    [SerializeField] GameObject overlayPause;
    [SerializeField] GameObject overlayFailed;
    [SerializeField] GameObject overlayFinish;

    // Start is called before the first frame update
    void Start()
    {
        ShowOverlayGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowOverlayGame()
    {
        overlayGame.SetActive(true);
        overlayPause.SetActive(false);
        overlayFailed.SetActive(false);
        overlayFinish.SetActive(false);
    }

    public void ShowOverlayPause()
    {
        overlayGame.SetActive(false);
        overlayPause.SetActive(true);
        overlayFailed.SetActive(false);
        overlayFinish.SetActive(false);
    }

    public void ShowOverlayFailed() 
    {
        overlayGame.SetActive(false);
        overlayPause.SetActive(false);
        overlayFailed.SetActive(true);
        overlayFinish.SetActive(false);
    }

    public void ShowOverlayFinish() 
    {
        overlayGame.SetActive(false);
        overlayPause.SetActive(false);
        overlayFailed.SetActive(false);
        overlayFinish.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
