using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour


{
    public AudioSource click;
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
        click.Play();
    }

    public void Options()
    {
        SceneManager.LoadScene("OptionsMenu");
        click.Play();
    }

    public void QuitGame()
    {
        Application.Quit();
        click.Play();
    }
}