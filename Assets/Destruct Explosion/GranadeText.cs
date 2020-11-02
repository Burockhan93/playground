using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadeText : MonoBehaviour
{
    List<Animator> _animators;
    public float wait = 0.1f;
    public float EndWait = 0.5f;
    void Start()
    {
        _animators = new List<Animator>(GetComponentsInChildren<Animator>());
        StartCoroutine(DoAnim());
    }

    IEnumerator DoAnim()
    {
        while (true)
        { 
            foreach(var animator in _animators)
            {
                animator.SetTrigger("DoAnim");
                yield return new WaitForSeconds(wait);

            }

            yield return new WaitForSeconds(EndWait);
        }
    }

}
