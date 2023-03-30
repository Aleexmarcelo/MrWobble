using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int damage = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            HealthBar healthBar = other.gameObject.GetComponent<HealthBar>();
            if (healthBar != null)
            {
                healthBar.Damage(damage);
            }
        }
        Debug.Log("Damage");
    }
}