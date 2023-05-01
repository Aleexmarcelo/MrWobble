using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonBlink : MonoBehaviour
{
    private bool isMouseOver;
    private Button button;
    private AudioSource audioSource;

    void Start()
    {
        button = GetComponent<Button>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnPointerEnter()
    {
        isMouseOver = true;
        audioSource.Play();
        StartCoroutine(Blink());
    }

    void OnPointerExit()
    {
        isMouseOver = false;
        button.image.enabled = true;
    }

    IEnumerator Blink()
    {
        while (isMouseOver)
        {
            button.image.enabled = !button.image.enabled;
            yield return new WaitForSeconds(0.5f);
        }
        button.image.enabled = true;
    }
}