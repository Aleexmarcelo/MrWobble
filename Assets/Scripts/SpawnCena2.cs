using UnityEngine;

public class SpawnCena2 : MonoBehaviour
{
    public GameObject objetoASpawnar; // O objeto que ser� spawnado
    public Transform[] posicoesSpawn; // Array com as posi��es de spawn
    public float tempoEntreSpawns = 0.5f; // Tempo entre cada spawn
    private int indicePosicaoAtual = 0; // �ndice da posi��o atual do spawn
    private bool spawnAtivo = false; // Bool para controlar se o spawn est� ativo ou n�o

    private void Start()
    {
        InvokeRepeating("SpawnarObjeto", 0f, tempoEntreSpawns);
    }

    private void Update()
    {
        // Aqui voc� pode adicionar l�gica adicional se necess�rio
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
