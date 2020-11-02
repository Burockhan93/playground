using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.Events;

public class Collision1 : MonoBehaviour
{
    public Rigidbody rb;
    public float a;
    public UnityEvent hit = new UnityEvent();
    public UnityEvent kapi = new UnityEvent();
    AudioSource source;
    public AudioClip step;

    void Start()
    {
        
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Input.GetAxis("Vertical") * a, 0, Input.GetAxis("Horizontal") * -a);
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.red);
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        // hit.Invoke(); oldu bu
        kapi.Invoke();
        source.PlayOneShot(step,1f);
    }

 }

