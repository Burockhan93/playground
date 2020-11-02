using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityScript.Steps;

public class explosion : MonoBehaviour
{
    public float delay = 3f;
    float countdown;
    bool hasExploded;
    public float radius;
    public GameObject explosionEffect;
    GameObject explosionInstance;
    public float explForce;

     void Start()
    {
        countdown = delay;
        hasExploded = false;
        
    }
     void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0 && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }
    void Explode()
    {
        explosionInstance= Instantiate(explosionEffect, transform.position, transform.rotation);

        Collider [] collidersdestroy = Physics.OverlapSphere(transform.position, radius);

        foreach(Collider nearbyobject in collidersdestroy)
        {
            Destruct ds = nearbyobject.GetComponent<Destruct>();
            if (ds != null)
            {
                ds.GranadeDestroy();
            }
        }

        Collider[] collidersmove = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyobject in collidersmove)
        {
            Rigidbody rb = nearbyobject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explForce, transform.position, radius);
            }

            Destruct ds = nearbyobject.GetComponent<Destruct>();
            if (ds != null)
            {
                ds.GranadeDestroy();
            }
        }

        Destroy(gameObject);
        Destroy(explosionInstance, 3f);
    }
}
