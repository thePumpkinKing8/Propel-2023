using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public bool SettingsOpen = false;
    public bool GameOverOpen = false;
    public bool PauseOpen = false;
    public bool SoundOn = true;

    [SerializeField]
    public GameObject PauseScreen;
    public GameObject GameOverScreen;
    public AudioSource ButtonClickSound;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        TogglePause();
    }

    public void PlayButtonSound()
    {
        ButtonClickSound.Play();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("main");
    }

    public void TogglePause()
    {
        PauseOpen = !PauseOpen;
        PauseScreen.SetActive(PauseOpen);
    }

    public void OnStartButton()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnExitButton()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
    public void ToggleSound()
    {
        SoundOn = !SoundOn;
    }
}
