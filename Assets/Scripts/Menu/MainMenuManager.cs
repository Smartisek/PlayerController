using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private String gameSceneName = "GameScene";
    [SerializeField] private String optionsSceneName = "OptionsScene";

    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void OpenSettings(){
        SceneManager.LoadScene(optionsSceneName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
