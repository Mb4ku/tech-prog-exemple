using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    Vector3 m_Move;
    Vector3 m_Rotate;
    
    public Rigidbody m_Rigidbody;
    float Sprint;
    public float m_JumpSpeed = 200f;
    private bool m_CanJump;


    // Start is called before the first frame update
    void Start()
    {
        m_CanJump = false;
        m_Move = new Vector3();
        m_Rotate = new Vector3();
 
}
    // Update is called once per frame
    void Update()
    {
        
        m_Move.z = 0;

        Sprint = 1f;


        if (Input.GetKey(KeyCode.LeftShift))
        {
            Sprint = 2f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            m_Move.z = (1f * Sprint);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            m_Move.z = (-1f * Sprint);
        }
        else
        {
            m_Move.z = 0;
        }
        transform.Translate(m_Move);

        if(Input.GetKey(KeyCode.D))
        {
            m_Rotate.y =  + 2f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            m_Rotate.y = -2f;
        }
        else
        {
            m_Rotate.y = 0f;
        }
        transform.Rotate(m_Rotate);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (m_CanJump)
            {
                m_Rigidbody.AddForce(0f, m_JumpSpeed, 0f);
                m_CanJump = false;
            }
        }
    }  
 
    private void OnCollisionEnter(Collision collision)
    {
        m_CanJump = true;
    }

}
