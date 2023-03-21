using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStop : MonoBehaviour
{
    public Animator raioStart;
    public Animator raioDois;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SetaMusica")
        {
            raioStart.SetBool("Raio", false);
            raioDois.SetBool("Raio", false);
            Destroy(this.gameObject);
        }
    }
}
