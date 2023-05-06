using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossThrowAnim : MonoBehaviour
{
    public Animator boss1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SetaMusica")
        {
            boss1.SetBool("Smash2L", true);
            boss1.SetBool("MusicStart", false);
                }
        else
            {
                boss1.SetBool("Smash2L", false);
                boss1.SetBool("MusicStart", true);
            }
            Destroy(this.gameObject);      
        }
    }
