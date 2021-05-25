using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource DeadAudio;//initializing bird die audio
  
    // Start is called before the first frame update
    void Start()
    {
        DeadAudio = GetComponent<AudioSource>();//getting the component audio source
       
       
    }
    

    public void PlayAudio()
    {
        DeadAudio.Play();//To play the Dead Audio
    }
}
