using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "Cylinder";
        ForceJump = 12.5f;
        m_ShapeRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    protected override void Jump()
    {
        m_ShapeRb.AddForce(Vector3.up * ForceJump, ForceMode.VelocityChange);
    }
}
