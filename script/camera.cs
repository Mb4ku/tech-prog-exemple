using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
    
{
    Vector3 up = new Vector3();
    public float chrono = 3.0f;
    bool arrete;

    // Start is called before the first frame update
    void Start()
    {

        arrete = true;
        

            
        


    }

    // Update is called once per frame
    void Update()
    {
        chrono -= Time.deltaTime;

        if (chrono <= 0f && arrete == true)
        {
            up = transform.position;
            up.y = up.y + 0.01f;
            transform.position = up;

        }
        if (transform.position.y >= 18f)
        {
            up.y = 0f;
            
            arrete = false;
        }





    }
}
