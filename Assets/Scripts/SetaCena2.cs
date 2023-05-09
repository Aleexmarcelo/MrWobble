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
    private void Awake()
    {
        Seta.SetBool("MusicaStart", true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Musica")
        {
            Musica.Play();
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "Video")
        {
            Destroy(other.gameObject);
            Destroy(Video);
        }
    }
}
