using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public string sceneName;

    void Start()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(5f); //Aguarda 4 segundos para o vídeo terminar
        SceneManager.LoadScene(sceneName); //Carrega a cena especificada
    }
}
