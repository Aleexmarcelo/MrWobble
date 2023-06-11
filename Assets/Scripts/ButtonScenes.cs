using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScenes : MonoBehaviour
{
    public AudioSource click;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadScenes(string scene)
    {
        SceneManager.LoadScene(scene);
        click.Play();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
