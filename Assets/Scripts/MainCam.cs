using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Animations;
using System;

public class MainCam : MonoBehaviour
{
    Camera cam;
    DOTweenLight isik;
    public GameObject kapsul;
    public GameObject player;
    Vector3 distance;

    bool isEffect;
    Sequence seq;


    IEnumerator lookat;
    
    
    

    public static MainCam instance;
    void Awake()
    {
        instance = this;
        isik = DOTweenLight.instance;
        isEffect = false;
        seq = DOTween.Sequence();
    }
    void Start()
    {
        
        cam = this.GetComponent<Camera>();
        //distance =  kapsul.transform.position - transform.position;// Mousetiklama yaptigin yerde kullan
        distance = transform.position - player.transform.position;
        
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (isEffect) return;
        //cam.transform.LookAt(kapsul.transform); //5 tane karoyla ugrascaagn zaman ac
        cam.transform.position = distance + (player.transform.position);
        cam.transform.LookAt(player.transform);


    }
    public void follow()
    {
        transform.DOMoveX(kapsul.transform.position.x+distance.x, 0.5f);
        transform.DOMoveZ(kapsul.transform.position.z + distance.z, 0.5f);
        
    }

    public void Shake()
    {
        lookat = LookAt();
        isEffect = true;
        seq.Append(cam.DOShakePosition(5, 3, 100, 90, false).OnStart(() => StartCoroutine(lookat)).OnComplete(() => { isEffect = false;StopCoroutine(lookat); }));
        //enabled = false;
        
            //cam.DOShakePosition(5, 3, 100, 90, false).OnComplete(()=> { isEffect = false; });
            Debug.Log("Heey");
        //StartCoroutine(Wait());
        
    }

    private IEnumerator LookAt()
    {
        while (isEffect)
        {
            yield return  null;
            transform.LookAt(player.transform.position);
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        //enabled = true;
    }
}
