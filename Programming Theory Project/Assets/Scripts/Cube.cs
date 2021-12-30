using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    
    // Start is called before the first frame update
    void Start()
    {
        Name = "Cube";
        ForceJump = 15.0f;
        m_ShapeRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 2.0f)
        {
            Jump();
        }
    }

    protected override void Jump()
    {
        m_ShapeRb.AddForce(Vector3.up * ForceJump, ForceMode.Impulse);
    }
}
