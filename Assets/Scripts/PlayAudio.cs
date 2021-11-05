using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayAudio : MonoBehaviour
{

    public AudioSource intro;
    public AudioSource ghostNormal;
    
    // Start is called before the first frame update
    void Start()
    {
        intro.Play();
        ghostNormal.PlayDelayed(intro.clip.length);
    }

    // Update is called once per frame
    void Update()
    {

    }


    
}
