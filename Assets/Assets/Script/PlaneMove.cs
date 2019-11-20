using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour
{
    public float PlaneSpeed;
    Vector3 m_Move = new Vector3();
    Vector3 m_Rotate = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        m_Move.x = 0;
        m_Rotate.z = 0;

    }

    // Update is called once per frame
    void Update()
    {
        m_Move.x = PlaneSpeed;
        m_Rotate.z = PlaneSpeed;
        transform.Translate(m_Move);
        transform.Rotate(m_Rotate);
    }
}
