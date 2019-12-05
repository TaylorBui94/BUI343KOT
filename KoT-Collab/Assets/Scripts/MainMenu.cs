using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
    This MainMenu script was also used to give functionality to the esc 
    options/pause panel as a test of how C# handles null references. 
    It yells at you, but it still runs perfectly. When you press esc in the main menu, nothing happens as intended even though the same code allows you
    to pause within the GameBoard
*/

public class MainMenu : MonoBehaviour
{   
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    void Start() {
        //pauseMenuUI.SetActive(false);
    }

    public void PlayGame() {
        SceneManager.LoadScene("PlayerSetup");
    }

    public void Menu() {
        Debug.Log("inside GotoMainMenu method");
        SceneManager.LoadScene("Menu");
    }

    public void Exit() {
        Application.Quit();
    }

    void Update() {
        if(SceneManager.GetActiveScene().name.Equals("GameBoard")) {
            if (Input.GetKeyDown(KeyCode.Escape)) {
            
            if (GameIsPaused) {
                Resume();
            } else {
                Pause();
            }
        }
        }
        
    }

    public void Resume() {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
    }
    void Pause() {
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
    }

}
