using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilkaOdbicie : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector3 lastVelocity;

   
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        lastVelocity = rb.velocity;
    }


    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision2D.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
    }
}