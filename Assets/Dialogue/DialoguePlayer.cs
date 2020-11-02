using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePlayer : MonoBehaviour
{
    CharacterController cont;
    [Range (0,10)]public float MoveSpeed;

    

    private Vector3 _playerMove;
    void Start()
    {
        cont = gameObject.GetComponent<CharacterController>();   

    }

    // Update is called once per frame
    void Update()
    {
        _playerMove = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
        _playerMove = _playerMove.normalized* MoveSpeed;
        cont.Move(_playerMove*Time.deltaTime);

        if (_playerMove.sqrMagnitude != 0)
        {
            MainCam.instance.DOKill();
        }
    }

    
}
