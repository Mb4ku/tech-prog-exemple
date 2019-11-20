using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move2D : MonoBehaviour
{
    Vector3 m_Move;
    public Rigidbody m_Rigidbody;
    public float m_JumpSpeed;
    private bool m_CanJump;
    public float Speed;
    public AudioSource Grass;
    int Count;
    public Text m_Score;

    // Start is called before the first frame update
    void Start()
    {
        Count = 0; 
        m_CanJump = false;
        m_Move = new Vector3();

        
    }
    // Update is called once per frame
    void Update()
    {

        m_Move.x = 0;

        if (Input.GetKey(KeyCode.D))
        {
            m_Move.x = + Speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            m_Move.x = - Speed;
        }
        else
        {
            m_Move.x = 0f;
        }
        transform.Translate(m_Move);


        if (Input.GetKeyDown(KeyCode.W))
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

    }

}
