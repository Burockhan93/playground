using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventstest : MonoBehaviour
{
    public Collision1 _box;
    
    void Awake()
    {
        _box.hit.AddListener(carpisma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void carpisma()
    {
        print("Heey!");
    }
}
