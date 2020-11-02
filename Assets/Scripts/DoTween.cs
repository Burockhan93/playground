using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class DoTween : MonoBehaviour
{
    [SerializeField]
    private Vector3 _targetloc = Vector3.zero;

    [Range (1.0f,10.0f), SerializeField]
    private float _time = 1.0f;

    [SerializeField]
    private Ease _moveEase ;

    [SerializeField]
    private DoTweenType _doTweenType ;

    [SerializeField]
    private Color _color;

    [SerializeField]
    private Color _color1;

    [Range(1.0f, 10.0f), SerializeField]
    private float _colorTime;

    [Range(1.0f, 100.0f), SerializeField]
    private float _scale = 3.0f;

    

    

    private enum DoTweenType
    {
        MovementOneway,MovementTwoWay,MovementColor,MovementTwoWay2,MoveScale,docolor,dogradient
    }

    void Start()
    {

        if (_doTweenType == DoTweenType.MovementOneway)
        {
            if (_targetloc == Vector3.zero)
                _targetloc = transform.position;

            transform.DOMove(_targetloc, _time).SetEase(_moveEase);// Ease degiskeni kendimit yaptik.bunu eklemek gerekiyor DOMove un alt metodu
        }
        else if (_doTweenType == DoTweenType.MovementTwoWay)
        {
            if (_targetloc == Vector3.zero)
                _targetloc = transform.position;

            StartCoroutine(Move2());
        }
        else if (_doTweenType == DoTweenType.MovementColor) // renk degistirme animasyonu olacak
        {
            if (_targetloc == Vector3.zero)
                _targetloc = transform.position;

            DOTween.Sequence().Append(transform.DOMove(_targetloc, _time).SetEase(_moveEase))
                .Append(transform.GetComponent<Renderer>().material.DOColor(_color, _colorTime).SetEase(_moveEase));
        }
        else if (_doTweenType == DoTweenType.MovementTwoWay2)
        {
            if (_targetloc == Vector3.zero)
                _targetloc = transform.position;
            Vector3 originalPosition = transform.position;
            DOTween.Sequence().Append(transform.DOMove(_targetloc, _time).SetEase(_moveEase)).Append(transform.DOMove(originalPosition, _time).SetEase(_moveEase));
        }
        else if (_doTweenType == DoTweenType.MoveScale)
        {
            if (_targetloc == Vector3.zero)
                _targetloc = transform.position;

            DOTween.Sequence().Append(transform.DOMove(_targetloc, _time).SetEase(_moveEase))
                .Append(transform.GetComponent<Renderer>().material.DOColor(_color1, _colorTime).SetEase(_moveEase))
                .Append(transform.DOScale(_scale, _time / 2).SetEase(_moveEase));
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Move2()
    {
        Vector3 originalPosition = transform.position;
        transform.DOMove(_targetloc, _time).SetEase(_moveEase);
        yield return new WaitForSeconds(1);
        transform.DOMove(originalPosition, _time).SetEase(_moveEase);
    }
}
