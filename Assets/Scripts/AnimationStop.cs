using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStop : MonoBehaviour
{
    public Animator raioStart;
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "SetaMusica")
        {
            Debug.Log("Deu.");
            raioStart.SetBool("Raio", false);
        }
    }
}
