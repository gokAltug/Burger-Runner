using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Using singleton pattern
    public static GameManager instance;
    public bool isGameStarted;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            UIManager.Instance.tap2playButton.SetActive(false);
            isGameStarted = true;
        }
    }


    public void PauseGame() => Time.timeScale = 0;
    public void ResumeGame() => Time.timeScale = 1;






}
