using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTweenLight : MonoBehaviour
{
    Light isik;
    public static DOTweenLight instance;
  
     void Awake()
    {
        
        instance = this;
    }
     void Start()
    {
        isik = GetComponent<Light>();
    }

     public DOTweenLight docolor(Color a, float b)
    {
        isik.DOColor(a, b);
        return instance;
    }
    public DOTweenLight dointens(float a, float b)
    {
        isik.DOIntensity(a, b);
        return instance;
    }
    public DOTweenLight doshadow(float a, float b)
    {
        isik.DOShadowStrength(a, b);
        return instance;
    }
}
