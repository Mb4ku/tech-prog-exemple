using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour


{
    public Vector3 m_velo = new Vector3();
    public Rigidbody m_rigi;
    public float m_HauteurSaut = 10f;
    bool can_jump;
    
    // Start is called before the first frame update
    void Start()
    {
        can_jump = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 m_velo;
        //mouvement et jump
        m_velo = m_rigi.velocity;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_velo.x = m_velo.x - 0.3f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            m_velo.x = m_velo.x + 0.3f;
        }
        else
        {
            m_velo.x = 0f;
        }
        m_rigi.velocity = m_velo;

        if (can_jump = true && Input.GetKeyDown(KeyCode.Space))
        {

            m_rigi.AddForce(0f, m_HauteurSaut, 0f);
            can_jump = false;




        }
    }

    void OnCollisionEnter(Collision collision)
    {
        can_jump = true;

    }
    private void OnCollisionExit(Collision collision)
    {
        can_jump = false;
    }


}

























































