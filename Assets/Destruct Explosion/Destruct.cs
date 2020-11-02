using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruct : MonoBehaviour
{
    public GameObject destroyedCrate;
    GameObject destroyedCrate1;
    public GameObject explosionEffect;
    void OnMouseDown()
    {
        Instantiate(destroyedCrate, transform.position, transform.rotation);
        //Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public void GranadeDestroy()
    {
        destroyedCrate1 = Instantiate(destroyedCrate, transform.position, transform.rotation);
        
        Destroy(gameObject);
        int random = Random.Range(2, 6);
        Destroy(destroyedCrate1, random);
    }
}
