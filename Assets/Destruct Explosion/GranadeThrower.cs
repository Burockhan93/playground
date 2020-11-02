using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GranadeThrower : MonoBehaviour
{
     float throwForce = 50;
    public GameObject granadePrefab;
    GameObject granade;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            throwgranade();
        } 
    }

    void throwgranade()
    {
        granade = Instantiate(granadePrefab, transform.position, transform.rotation);
        Rigidbody rb = granade.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.left * throwForce);
    }
}
