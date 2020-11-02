using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movementDOTween : MonoBehaviour
{
    public AudioClip move;
    AudioSource source;

     void Start()
    {
        source = GetComponent<AudioSource>();
    }
    public static movementDOTween instance;
     void Awake()
    {
        instance = this;
    }
   public void Play()
    {
        source.PlayOneShot(move);
    }
   
}
