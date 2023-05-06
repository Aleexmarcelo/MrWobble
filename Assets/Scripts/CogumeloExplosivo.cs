using UnityEngine;
using System.Collections;

public class CogumeloExplosivo : MonoBehaviour
{
    public float destroyDelay = 2.7f;
    public float explosionRadius = 1f;
    public GameObject explosionPrefab;
    public int damageAmount = 10;
    public string playerTag = "Player";
    public GameObject hudController;
    public int damage = 5;

    private void Start()
    {
        Invoke("DestroySelf", destroyDelay);
    }

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

    private IEnumerator Explode()
    {
        GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        explosion.transform.localScale = Vector3.one * explosionRadius;
        yield return new WaitForSeconds(explosion.GetComponent<ParticleSystem>().main.duration);
        Destroy(explosion);
        Destroy(gameObject);

    }

    private void DestroySelf()
    {
        StartCoroutine(Explode());
    }
}
