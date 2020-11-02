using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otomatikkapi : MonoBehaviour
{
    [SerializeField] private Collision1 _player;
    AudioSource source;
    public AudioClip rockMusic;
    int sayi1 = 0;


    void Start()
    {
        _player.kapi.AddListener(acil);
        source = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void acil()
    {

        transform.DOMove((transform.position+ Vector3.up),1f);
        int sayi = Random.Range(1, 5);
        
        sayi1++;

        switch (sayi)
        {
            case 1: _player.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                break;
            case 2: _player.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                break;
            case 3: _player.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
                break;
            case 4: _player.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
                break;
            default:
                break;
        }
        //source.Play();
        //sesKontrol();
        //sespitch();
        
        
        
       
    }
    void sesKontrol()
    {
        if (source.isPlaying)
        {
            source.Pause();
        }
        else
        {
            source.Play();
        }


    }
    void sespitch()
    {
        if (sayi1 == 3)
        {
            source.DOPitch(2, 2);
        }
    }
   
}
