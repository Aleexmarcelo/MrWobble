using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogumeloExplosivo : MonoBehaviour
{
    public GameObject prefabToSpawn; // referência ao prefab a ser spawnado
    public float spawnRadius; // raio em que o prefab será spawnado
    public int maxSpawnAttempts = 10; // número máximo de tentativas de spawnar antes de desistir
    public float spawnInterval = 1f; // intervalo de tempo entre spawns

    private float timeUntilNextSpawn; // tempo restante até o próximo spawn
    private bool canSpawn; // indica se é permitido spawnar

    private void Start()
    {
        canSpawn = false;
    }

    private void Update()
    {
        if (canSpawn)
        {
            // diminuir o tempo restante até o próximo spawn
            timeUntilNextSpawn -= Time.deltaTime;

            // verificar se é hora de spawnar
            if (timeUntilNextSpawn <= 0f)
            {
                SpawnObject();
                timeUntilNextSpawn = spawnInterval;
            }
        }
    }

    private void SpawnObject()
    {
        // tentar spawnar o prefab várias vezes até encontrar uma posição válida
        for (int i = 0; i < maxSpawnAttempts; i++)
        {
            // gerar uma posição aleatória dentro do raio especificado
            Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;

            // verificar se a posição gerada está livre para spawnar
            if (Physics.CheckSphere(spawnPosition, 1f))
            {
                // a posição não está livre, tentar novamente
                continue;
            }

            // a posição está livre, spawnar o prefab
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
            break;
        }
    }

    public void StartSpawning()
    {
        canSpawn = true;
        timeUntilNextSpawn = spawnInterval;
    }
}