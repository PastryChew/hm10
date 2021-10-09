using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringController : MonoBehaviour
{
    private float springTimer;

    public int springForce;
    public Rigidbody rb;


    void Start()
    {
        springTimer = -2;
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        springTimer -= Time.deltaTime;

        if (springTimer > -1)
        {
            rb.AddForce(1 * springForce, 0, 0, ForceMode.Impulse);
            springTimer = -2;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            springTimer = 2;
        }
    }
}
