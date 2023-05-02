using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float speed = 10.0f;

    void FixedUpdate()
    {
        transform.Rotate(0,0, speed * Time.fixedDeltaTime);
    }
}
