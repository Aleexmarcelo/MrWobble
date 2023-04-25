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
            Saw1.SetBool("Start", true);
            Saw1.SetBool("Idle", false);
            boss1.SetBool("Smash2L", true);
            boss1.SetBool("MusicStart", false);
            Destroy(this.gameObject);
        }
    }
}
