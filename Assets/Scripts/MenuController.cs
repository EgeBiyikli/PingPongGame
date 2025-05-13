using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    [SerializeField] Button playButton;
    [SerializeField] Button quitButton;

    public void PlayGame() {
        SceneManager.LoadScene(1);
    }
    public void QuitGame() { 
        Application.Quit();
    }
}
