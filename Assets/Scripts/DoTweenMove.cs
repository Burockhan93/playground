using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoTweenMove : MonoBehaviour
{
    [SerializeField]private Ease _move;


    public Transform p1;
    public Transform p2;
    public Transform p3;
    public Transform p4;
    public Transform p5;

    public GameObject sphere;

    void Start()
    {
        Sequence firstSequence = DOTween.Sequence();     //DoTween de sequencelar önemli art arda hareketler ve eszamanli hareketler böyl yapiliyor
        Sequence secondSequence = DOTween.Sequence();
        Sequence thirdSequence = DOTween.Sequence();
        Sequence fourthSequence = DOTween.Sequence();

        //transform.DOLookAt(new Vector3(0,0,0), 1f);

        //firstSequence = transform.DOJump(p1.position, 10,2,5).Append(transform.DOJump(p2.position,5,3,4)).Append(transform.DOJump(p3.position, 5, 3, 4))
        //.Append(transform.DORotate(new Vector3(1800, 0, 0), 5, RotateMode.FastBeyond360));

        secondSequence = sphere.transform.DOJump(p4.position, 5, 3, 4).Append(sphere.transform.DOJump(p5.position, 3, 3, 3))
            .Append(sphere.transform.DOPunchPosition(Vector3.up, 2, 33, 0)).Append(sphere.transform.DOPunchRotation(Vector3.up, 2, 33, 0))
            .Append(sphere.transform.DOPunchScale(new Vector3(10, 10, 10), 2, 33, 1));

        thirdSequence.Append(sphere.transform.DOShakePosition(2, new Vector3(3, 1, 3), 3, 90))
        .Append(sphere.transform.DOShakeRotation(2, new Vector3(3, 1, 3), 3, 90))
        .Append(sphere.transform.DOShakeScale(2, new Vector3(3, 1, 3), 3, 90));

        //fourthSequence = sphere.transform.DOJump(p4.position, 5, 3, 4).Append(sphere.transform.DOJump(p5.position, 3, 3, 3))
            //.AppendInterval(2).Append(sphere.transform.DOJump(p1.position, 5, 3, 4)).Append(sphere.transform.DOJump(p5.position, 3, 3, 3))
            //.Join(sphere.transform.DORotate(new Vector3(180, 0, 0), 5, RotateMode.FastBeyond360));
            //.Insert(1, sphere.transform.DOShakeScale(2, 10, 10, 90));



    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
