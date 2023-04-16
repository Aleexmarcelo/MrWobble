using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelStart : MonoBehaviour
{
    public AudioSource musicaplay;
    public Animator animatorBoss;
    public Animator setaStart;
    public CogumeloExplosivo spawner; // referência ao script SpawnPrefab

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            musicaplay.Play();
            animatorBoss.SetBool("MusicStart", true);
            setaStart.SetBool("MusicaStart", true);
            Destroy(gameObject);
        }
    }
}
