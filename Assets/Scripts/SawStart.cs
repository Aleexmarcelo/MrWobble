using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawStart : MonoBehaviour
{
    public Animator Saw1;
    public Animator boss1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SetaMusica")
        {
            boss1.SetBool("Smash2L", true);
            Saw1.SetBool("Idle", false);
            Saw1.SetBool("Serra1", true);
            boss1.SetBool("MusicStart", false);
            Destroy(this.gameObject);
        }
    }
}
