using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "Sphere";
        ForceJump = 10.0f;
        m_ShapeRb = GetComponent<Rigidbody>();
        InvokeRepeating("Jump", 1.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Jump()
    {
        m_ShapeRb.AddForce(Vector3.up * ForceJump, ForceMode.Impulse);
    }
}
