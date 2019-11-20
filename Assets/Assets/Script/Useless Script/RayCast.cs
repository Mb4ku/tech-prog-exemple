using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, new Vector3(0f, -1f, 0f), Color.red);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, new Vector3(0f, -1f, 0f), out hit, 1f))
        {
            Debug.Log(hit.distance);
        }
        else
        {
            Debug.Log("Nope");
        }
    
    }
}
