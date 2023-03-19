using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationStart : MonoBehaviour
{
    public Animator raioStart;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SetaMusica")
        {
            Debug.Log("Deu.");
            raioStart.SetBool("Raio", true);
        }
    }
}
