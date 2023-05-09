using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawStop : MonoBehaviour
{
    public Animator Saw1;
    public Animator boss1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SetaMusica")
        {
            Saw1.SetBool("Idle", true);
            boss1.SetBool("Smash2L", false);
            boss1.SetBool("MusicStart", true);
            Saw1.SetBool("Serra1", false);
            Saw1.SetBool("Serra2", false);
            Saw1.SetBool("Serra3", false);
            Destroy(this.gameObject);
        }
    }
}
