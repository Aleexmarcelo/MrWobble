using UnityEngine;

public class SpawnCena2 : MonoBehaviour
{
    public GameObject objetoASpawnar; // O objeto que será spawnado
    public Transform[] posicoesSpawn; // Array com as posições de spawn
    public float tempoEntreSpawns = 0.5f; // Tempo entre cada spawn
    private int indicePosicaoAtual = 0; // Índice da posição atual do spawn
    private bool spawnAtivo = false; // Bool para controlar se o spawn está ativo ou não

    private void Start()
    {
        InvokeRepeating("SpawnarObjeto", 0f, tempoEntreSpawns);
    }

    private void Update()
    {
        // Aqui você pode adicionar lógica adicional se necessário
    }

    private void SpawnarObjeto()
    {
        if (spawnAtivo)
        {
            Instantiate(objetoASpawnar, posicoesSpawn[indicePosicaoAtual].position, Quaternion.identity);
        }
    }

    public void AlterarPosicaoSpawn()
    {
        int indicePosicaoAleatoria = Random.Range(0, posicoesSpawn.Length);
        indicePosicaoAtual = indicePosicaoAleatoria;
    }

    public void AtivarSpawn(bool ativo)
    {
        spawnAtivo = ativo;
    }
}
