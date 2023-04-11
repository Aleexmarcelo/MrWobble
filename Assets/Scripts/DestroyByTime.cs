using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
    public float LifeTime;
    public ParticleSystem explosionParticlePrefab;

    private ParticleSystem explosionParticle;

    public int damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        // Destrói o objeto após um determinado tempo
        Destroy(gameObject, LifeTime);

        // Instancia a partícula de explosão
        explosionParticle = Instantiate(explosionParticlePrefab, transform.position, transform.rotation, transform);
        explosionParticle.Stop();
        explosionParticle.transform.localScale = transform.localScale;
        explosionParticle.transform.localRotation = Quaternion.identity;
        explosionParticle.transform.localPosition = Vector3.zero;

        // Atrasa a explosão da partícula em 3 segundos
        Invoke("Explode", 3f);
    }

    void Explode()
    {
        if (explosionParticle != null)
        {
            explosionParticle.Play();

            // Destrói a partícula após ela terminar de tocar
            Destroy(explosionParticle.gameObject, explosionParticle.main.duration);
        }
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
}
