using UnityEngine;


public class LevelStart : MonoBehaviour
{
    public AudioSource musicaplay;
    public Animator animatorBoss;
    public Animator setaStart;
    public Timer timer;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timer.Begin(292);
            musicaplay.Play();
            animatorBoss.SetBool("MusicStart", true);
            setaStart.SetBool("MusicaStart", true);
            Destroy(gameObject);
        }
    }
}
