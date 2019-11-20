using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    public float CameraSpeed;
    Vector3 m_Move = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        m_Move.y = 0;

    }

    // Update is called once per frame
    void Update()
    {
        m_Move.y = CameraSpeed;
        transform.Translate(m_Move);
    }
}
