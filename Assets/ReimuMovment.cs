using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReimuMovment : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator anima;

    Vector2 movment;
    // Update is called once per frame
    void Update()
    {
        movment.x = Input.GetAxis("Horizontal");
        movment.y = Input.GetAxis("Vertical");

        anima.SetFloat("Horizontal", movment.x);
        anima.SetFloat("Vertical", movment.y);
        anima.SetFloat("Speed", movment.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movment * moveSpeed * Time.fixedDeltaTime);
    }
}
