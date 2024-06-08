using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public AudioSource backgroundMusic;
    public Slider slider;
    public GameObject menuOptions;
    private bool isOptionsActived = false;
    private void Start()
    {
        menuOptions.SetActive(isOptionsActived);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void SelectLevel()
    {
        
    }
    public void SelectCharacter()
    {

    }
    public void Options()
    {
        isOptionsActived = !isOptionsActived;
        menuOptions.SetActive(isOptionsActived);
    }
    public void ChangeAudio()
    {
        float vol = Mathf.Log10((float)slider.value) * 20f;
        backgroundMusic.volume = vol;
        Debug.Log("20 por logaritmo en base 10 de " + slider.value + ": " + backgroundMusic.volume);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}