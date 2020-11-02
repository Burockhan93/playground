using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class movementDoTweenKarolar : MonoBehaviour
{
    [SerializeField] private Ease _move;
     void OnMouseDown()
    {
        movementDOTween.instance.transform.DOMove(transform.position,0.5f).SetEase(_move).OnComplete(ArrivedOnKaro);
        MainCam.instance.follow();
    }

    void ArrivedOnKaro()
    {
        movementDOTween.instance.transform.DOShakeScale(0.3f,0.3f);
        movementDOTween.instance.Play();
    }
}
