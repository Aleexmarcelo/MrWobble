using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogumeloExplosivo : MonoBehaviour
{
    public GameObject prefabToSpawn; // refer�ncia ao prefab a ser spawnado
    public float spawnRadius; // raio em que o prefab ser� spawnado
    public int maxSpawnAttempts = 10; // n�mero m�ximo de tentativas de spawnar antes de desistir
    public float spawnInterval = 1f; // intervalo de tempo entre spawns

    private float timeUntilNextSpawn; // tempo restante at� o pr�ximo spawn
    private bool canSpawn; // indica se � permitido spawnar

    private void Start()
    {
        canSpawn = false;
    }

    private void Update()
    {
        if (canSpawn)
        {
            // diminuir o tempo restante at� o pr�ximo spawn
            timeUntilNextSpawn -= Time.deltaTime;

            // verificar se � hora de spawnar
            if (timeUntilNextSpawn <= 0f)
            {
                SpawnObject();
                timeUntilNextSpawn = spawnInterval;
            }
        }
    }

    private void SpawnObject()
    {
        // tentar spawnar o prefab v�rias vezes at� encontrar uma posi��o v�lida
        for (int i = 0; i < maxSpawnAttempts; i++)
        {
            // gerar uma posi��o aleat�ria dentro do raio especificado
            Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;

            // verificar se a posi��o gerada est� livre para spawnar
            if (Physics.CheckSphere(spawnPosition, 1f))
            {
                // a posi��o n�o est� livre, tentar novamente
                continue;
            }

            // a posi��o est� livre, spawnar o prefab
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