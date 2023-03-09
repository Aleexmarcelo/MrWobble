using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimations : MonoBehaviour
{
    public Animation bossAnimator;
    public string[] animationNames;
    private int currentAnimation = 0;



     void Start()
    {
        PlayNextAnimation();
        
    }

     void Update()
    {
        if (!bossAnimator.isPlaying)
        {
            PlayNextAnimation();
        }
    }

    void PlayNextAnimation()
    {
        if(currentAnimation < animationNames.Length)
        {
            bossAnimator.Play(animationNames[currentAnimation]);
            currentAnimation++;
        }

        else
        {
            currentAnimation = 0;
            bossAnimator.Play(animationNames[currentAnimation]);
        }
    }
}