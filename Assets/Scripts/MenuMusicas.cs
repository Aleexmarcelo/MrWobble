using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuMusicas : MonoBehaviour
{

    public AudioSource click;
    public AudioSource music;
    public Button music1Button;
    public Button music2Button;
    public Button music3Button;
    public AudioClip chorao;
    public AudioClip badman;
    public AudioClip believer;
    public GameObject MusicBadman;
    public GameObject MusicChorao;
    public GameObject MusicBeliever;


    void Start()
    {
        music1Button.onClick.AddListener(PlayMusic1);
        music2Button.onClick.AddListener(PlayMusic2);
        music3Button.onClick.AddListener(PlayMusic3);
    }

    public void PlayMusic1()
    {
        music.clip = badman;
        music.Play();
        StartCoroutine(StopMusicAfterSeconds(music, 5f));
        MusicBadman.SetActive(true);
        MusicChorao.SetActive(false);
        MusicBeliever.SetActive(false);

    }

    public void PlayMusic2()
    {
        music.clip = believer;
        music.Play();
        StartCoroutine(StopMusicAfterSeconds(music, 5f));
        MusicBadman.SetActive(false);
        MusicChorao.SetActive(true);
        MusicBeliever.SetActive(false);
    }

    public void PlayMusic3()
    {
        music.clip = chorao;
        music.Play();
        StartCoroutine(StopMusicAfterSeconds(music, 5f));
        MusicBadman.SetActive(false);
        MusicChorao.SetActive(false);
        MusicBeliever.SetActive(true);
    }

    IEnumerator StopMusicAfterSeconds(AudioSource music, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        music.Stop();
        /* adicione aqui o botão 'ok' que leva à próxima cena */
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("Level1");
        click.Play();
    }
}
