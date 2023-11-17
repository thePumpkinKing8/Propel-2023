using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public bool SettingsOpen = false;
    public bool GameOverOpen = false;
    public bool PauseOpen = false;
    public bool IsMuted = false;

    [SerializeField]
    public GameObject PauseScreen;
    public GameObject GameOverScreen;
    public Image ButtonImage;
    public Sprite SoundOnSprite;
    public Sprite SoundOffSprite;
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
    public void OnMuteButton()
    {
        IsMuted = !IsMuted;
        if (IsMuted)
        {
            Debug.Log("Sound is off");
            ButtonImage.sprite = SoundOffSprite;
        }
        else if (!IsMuted)
        {
            Debug.Log("Sound is on");
            ButtonImage.sprite = SoundOnSprite;
        }
    }

}
