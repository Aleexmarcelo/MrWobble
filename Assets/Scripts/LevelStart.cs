using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class LevelStart : MonoBehaviour
{
    public AudioSource musicaplay;
    public Animator animatorBoss;
    public Animator raioTeste;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            musicaplay.Play();
            animatorBoss.SetBool("MusicStart", true);
            raioTeste.SetBool("Raio", true);
            Timer timer = FindAnyObjectByType<Timer>();
            Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("Player"))
        {

        }
    }
}