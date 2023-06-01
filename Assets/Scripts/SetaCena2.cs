using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class SetaCena2 : MonoBehaviour
{
    public Animator Seta;
    public AudioSource Musica;
    public RawImage Video;
    private SpawnCena2 spawnerScript; // Referência para o script SpawnCena2

    private void Awake()
    {
        Seta.SetBool("MusicaStart", true);
        spawnerScript = FindObjectOfType<SpawnCena2>(); // Encontrar o componente SpawnCena2 na cena
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Musica")
        {
            Musica.Play();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Video")
        {
            Destroy(other.gameObject);
            Destroy(Video);
        }

        if (other.gameObject.tag == "Gatilho" && spawnerScript != null)
        {
            spawnerScript.AlterarPosicaoSpawn();
        }

        if (other.gameObject.tag == "SpawnStart" && spawnerScript != null)
        {
            spawnerScript.AtivarSpawn(true); // Ativa o spawn de gameobjects
        }
    }
}
