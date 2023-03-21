using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationStart : MonoBehaviour
{
    public Animator raioStart;
    public Animator raioDois;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SetaMusica")
        {
            raioStart.SetBool("Raio", true);
            raioDois.SetBool("Raio", true);
            Destroy(this.gameObject);
        }
    }
}
