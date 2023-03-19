using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStop : MonoBehaviour
{
    public Animator raioStart;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SetaMusica")
        {
            raioStart.SetBool("Raio", false);
            Destroy(this.gameObject);
        }
    }
}
