using UnityEngine;

public class EnemyCena2 : MonoBehaviour
{
    public float velocidade = 15f; // Velocidade de movimento do objeto

    private void Start()
    {
        Destroy(gameObject, 5f); // Destroi o objeto após 5 segundos
    }

    private void Update()
    {
        // Movimento do objeto na direção do eixo Z
        transform.Translate(Vector3.back * velocidade * Time.deltaTime);
    }
}
