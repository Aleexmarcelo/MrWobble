using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class LevelStart : MonoBehaviour
{
    public AudioSource musicaplay;
    public GameObject boss1;
    public Vector3 novaPosicao;
    private bool playerEntrou = false;
    public float speedMove;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerEntrou = true;
            musicaplay.Play();
            boss1.transform.position = Vector3.MoveTowards(transform.position, novaPosicao, speedMove * Time.deltaTime);
        }
    }

    private void Update()
    {
        if(playerEntrou)
        {
            if(transform.position == novaPosicao)
            {
                playerEntrou = false;           
            }
        }
    }
}
