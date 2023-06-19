using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Final : MonoBehaviour
{

    public string scene;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SetaMusica")
        {
            SceneManager.LoadScene(scene);
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(scene);
    }
}
