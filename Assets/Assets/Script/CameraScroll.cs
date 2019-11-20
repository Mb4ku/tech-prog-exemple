using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    public float CameraSpeed;
    Vector3 m_Move = new Vector3();
    bool canScroll;

    // Start is called before the first frame update
    void Start()
    {
        m_Move.y = 0;
        canScroll = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canScroll == true)
        {
            m_Move.y = CameraSpeed;
            transform.Translate(m_Move);
        }
    }
    public void Stop()
    {
        canScroll = false;
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Character")
        {
            canScroll = false;
        
        }
        Debug.Log("triggered");
    }*/
}
