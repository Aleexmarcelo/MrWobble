using UnityEngine;

public class Raio1 : MonoBehaviour
{
    /* public Transform startPoint; // Ponto inicial do raio (pedra)
    public GameObject[] objectsToChooseFrom; // Array dos objetos a serem escolhidos
    public float rayDuration = 1.0f; // Duração do raio em segundos
    private LineRenderer lineRenderer;
    private bool isRayActive = false;
    private GameObject chosenObject; // Objeto escolhido para ativar o raio
    private float timer = 0.0f; // Contador de tempo para desligar o raio

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2; // Definir o número de pontos para desenhar a linha
        lineRenderer.enabled = false; // Desativar o raio inicialmente
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gatilho"))
        {
            if (!isRayActive)
            {
                // Ativar o raio apenas se não estiver ativo
                ActivateRay();
            }
        }
    }

    private void ActivateRay()
    {
        isRayActive = true;
        lineRenderer.enabled = true;

        // Escolher aleatoriamente um objeto do array
        int randomIndex = Random.Range(0, objectsToChooseFrom.Length);
        chosenObject = objectsToChooseFrom[randomIndex];

        // Configurar os pontos do LineRenderer
        Vector3[] positions = { startPoint.position, chosenObject.transform.position };
        lineRenderer.SetPositions(positions);

        timer = 0.0f; // Reiniciar o contador de tempo
    }

    private void Update()
    {
        if (isRayActive)
        {
            timer += Time.deltaTime;

            if (timer >= rayDuration)
            {
                // Desligar o raio após a duração definida
                isRayActive = false;
                lineRenderer.enabled = false;
            }
        }
    } */
}
