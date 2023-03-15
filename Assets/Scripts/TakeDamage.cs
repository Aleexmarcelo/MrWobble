using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
public int damage = 10;

private void OnCollisionEnter(Collision collision)
{
    ThirdPersonMovement player = collision.gameObject.GetComponent<ThirdPersonMovement>();
    if (player != null)
    {
        player.TakeDamage(damage);
    }
}
}