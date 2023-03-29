using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationStart : MonoBehaviour
{
    public Animator raioStart;
    public Animator raioDois;
    public Animator boss1;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SetaMusica")
        {
            raioStart.SetBool("Raio", true);
            raioDois.SetBool("Raio", true);
            boss1.SetBool("Smash2L", true);
            boss1.SetBool("MusicStart", false);
            Destroy(this.gameObject);
        }
    }
}
