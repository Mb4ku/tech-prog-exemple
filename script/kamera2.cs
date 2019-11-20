using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera2 : MonoBehaviour
    
{
    Vector3 up = new Vector3();
    public float chrono = 3.0f;
    bool stop;

    // Start is called before the first frame update
    void Start()
    {

        stop = true;
        

            
        


    }

    // Update is called once per frame
    void Update()
    {
        chrono -= Time.deltaTime;

        if (chrono <= 0f && stop == true)
        {
            up = transform.position;
            up.y = up.y + 0.015f;
            transform.position = up;

        }
        if (transform.position.y >= 36f)
        {
            up.y = 0f;
            
            stop = false;
        }





    }
}
