using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class managerrr : MonoBehaviour
{
    [SerializeField] private List<GameObject> spheres;
    public Ease yukari;
    public Ease asagi;
    private Vector3[] loc;

    public Sequence firstSequence;
    public Sequence secondSequence;
    public Sequence thirdSequence;

    public float w;



    void Start()
    {
        loc = new Vector3[spheres.Count];
        w = 0.5f;

        for (int i = 0; i < spheres.Count; i++)
        {
            loc[i] = spheres[i].transform.position;
        }
        move();
    }

    private void move()
    {
        
        Sequence firstSequence = DOTween.Sequence();   //DoTween de sequencelar önemli art arda hareketler ve eszamanli hareketler böyl yapiliyor
        Sequence secondSequence = DOTween.Sequence();
        Sequence thirdSequence = DOTween.Sequence();

        firstSequence.Append(spheres[0].transform.DOMove(loc[0] + Vector3.up * 3, w)).SetEase(yukari)
           .Append(spheres[0].transform.DOMove(loc[0], w)).SetEase(asagi)
           .Join(secondSequence.Append(spheres[1].transform.DOMove(loc[1] + Vector3.up * 3, w)).SetEase(yukari)
            .Append(spheres[1].transform.DOMove(loc[1], w)).SetEase(asagi)
            .Join(thirdSequence.Append(spheres[2].transform.DOMove(loc[2] + Vector3.up * 3, w)).SetEase(yukari)
            .Append(spheres[2].transform.DOMove(loc[2], w)).SetEase(asagi))).AppendInterval(1).SetLoops(2).SetAutoKill(false);
    }

    IEnumerator tweenWait(float i)
    {
        yield return new WaitForSeconds(i);
        Debug.Log("Tween completed!");
    }

    IEnumerator SomeCoroutine()
    {
        Tween myTween = spheres[0].transform.DOMove(loc[0] + Vector3.up * 3, 1);
        yield return myTween.WaitForCompletion();
        // This log will happen after the tween has completed
        Debug.Log("Tween completed!");
    }

}
