using UnityEngine;

public class AnimationStop : MonoBehaviour
{
    public Animator raioStart;
    public Animator raioDois;
    public Animator boss1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SetaMusica")
        {
            raioStart.SetBool("Raio", false);
            raioDois.SetBool("Raio", false);
            boss1.SetBool("Smash2L", false);
            boss1.SetBool("MusicStart", true);
            Destroy(this.gameObject);
        }
    }
}
