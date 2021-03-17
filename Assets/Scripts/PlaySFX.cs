using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySFX : MonoBehaviour  
{
    public AudioSource btnSound;

    // Start is called before the first frame update

    private void Start()
    {
       
    }
    public void PlaySound()
    {
        btnSound.Play();

    }

}
