using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject cogumeloPrefab;
    public float spawnInterval = 2f;
    public int maxCogumelos = 5;
    public float spawnRadius = 5f;
    public Transform player;

    private bool canSpawn = false;
    private int currentCogumelos = 0;

    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
        canSpawn = false;
    }

    void Update()
    {
        if (canSpawn && currentCogumelos < maxCogumelos)
        {
            SpawnCogumelo();
        }
    }

    public void SpawnCogumelo()
    {
        Vector3 spawnPosition = player.position + Random.insideUnitSphere * spawnRadius;
        spawnPosition.y = transform.position.y;

        GameObject cogumelo = Instantiate(cogumeloPrefab, spawnPosition, Quaternion.identity);
        currentCogumelos++;

        CogumeloExplosivo cogumeloExplosivo = cogumelo.GetComponent<CogumeloExplosivo>();
        if (cogumeloExplosivo != null)
        {
            cogumeloExplosivo.hudController = gameObject;
        }

        StartCoroutine(ResetSpawn());
    }

    IEnumerator ResetSpawn()
    {
        yield return new WaitForSeconds(spawnInterval);
        currentCogumelos--;
    }
}
