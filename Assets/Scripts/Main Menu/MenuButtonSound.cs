using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonSound : MonoBehaviour
{
    [SerializeField] private AudioSource fxSource;
    [SerializeField] private AudioClip hoverSound;
    [SerializeField] private AudioClip clickSound;

    public void PlayHoverSound()
    {
        fxSource.PlayOneShot(hoverSound);
    }
    public void PlayClickSound()
    {
        fxSource.PlayOneShot(clickSound);
    }
}
