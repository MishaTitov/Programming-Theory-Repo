using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected Rigidbody m_ShapeRb;
    private string m_Name = "Shape";
    public string Name
    {
        get{ return m_Name;}
        set
        {
            if (value.Length > 20)
            {
                Debug.LogError("Length of name is too long! Must be shorter than 20 symbols.");
            }
            else
            {
                m_Name = value;
            }
        }
    }

    private float m_ForceJump;
    public float ForceJump
    {
        get {return m_ForceJump;}
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("Force of Jump can not be negative!");
            }
            else
            {
                m_ForceJump = value;
            }
        }
    }
    protected abstract void Jump();
}
