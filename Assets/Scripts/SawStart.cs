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
            boss1.SetBool("MusicStart", false);
            Destroy(this.gameObject);
        }
        int randomAnim = Random.Range(1, 4);
        switch (randomAnim)
        {
            case 1:
                Saw1.SetBool("Serra1", true);
                break;
            case 2:
                Saw1.SetBool("Serra2", true);
                break;
            case 3:
                Saw1.SetBool("Serra3",true);
                break;
        }
    }
}
