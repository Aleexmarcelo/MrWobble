using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogumeloStart : MonoBehaviour
{
    public GameObject levelStart;
    public SpawnObjects cogumeloSpawner;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SetaMusica"))
        {
            Debug.Log("Cogu");
            cogumeloSpawner.SpawnCogumelo();
            Destroy(this.gameObject);
        }
    }
}
