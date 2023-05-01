using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMusicas : MonoBehaviour
{

    public AudioSource click;
    public void PlayMusic1()
    {
        SceneManager.LoadScene("Level1");
        click.Play();
    }

    public void PlayMusic2()
    {
        SceneManager.LoadScene("Musica2");
        click.Play();
    }

    public void QuitGame()
    {
        Application.Quit();
        click.Play();
    }
}