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
    public Button music4Button;
    public AudioClip chorao;
    public AudioClip badman;
    public AudioClip believer;
    public AudioClip angra;
    public GameObject MusicBadman;
    public GameObject MusicChorao;
    public GameObject MusicBeliever;
    public GameObject MusicAngra;
    public string Cena;
    public string Cena2;


    void Start()
    {
        music1Button.onClick.AddListener(PlayMusic1);
        music2Button.onClick.AddListener(PlayMusic2);
        music3Button.onClick.AddListener(PlayMusic3);
        music4Button.onClick.AddListener(PlayMusic4);
    }

    public void PlayMusic1()
    {
        music.clip = badman;
        music.Play();
        StartCoroutine(StopMusicAfterSeconds(music, 5f));
        MusicBadman.SetActive(true);
        MusicChorao.SetActive(false);
        MusicBeliever.SetActive(false);
        MusicAngra.SetActive(false);

    }

    public void PlayMusic2()
    {
        music.clip = believer;
        music.Play();
        StartCoroutine(StopMusicAfterSeconds(music, 5f));
        MusicBadman.SetActive(false);
        MusicChorao.SetActive(true);
        MusicBeliever.SetActive(false);
        MusicAngra.SetActive(false);
    }

    public void PlayMusic3()
    {
        music.clip = chorao;
        music.Play();
        StartCoroutine(StopMusicAfterSeconds(music, 5f));
        MusicBadman.SetActive(false);
        MusicChorao.SetActive(false);
        MusicBeliever.SetActive(true);
        MusicAngra.SetActive(false);
    }

    public void PlayMusic4()
    {
        music.clip = angra;
        music.Play();
        StartCoroutine(StopMusicAfterSeconds(music, 5f));
        MusicBadman.SetActive(false);
        MusicChorao.SetActive(false);
        MusicBeliever.SetActive(false);
        MusicAngra.SetActive(true);
    }

    IEnumerator StopMusicAfterSeconds(AudioSource music, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        music.Stop();
    }

    public void LoadNextScene1()
    {
        SceneManager.LoadScene(Cena);
        click.Play();
    }

    public void LoadNextScene2()
    {
        SceneManager.LoadScene(Cena2);
        click.Play();

    }
}
