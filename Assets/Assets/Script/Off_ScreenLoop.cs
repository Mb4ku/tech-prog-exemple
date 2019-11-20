using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Off_ScreenLoop : MonoBehaviour
{
    
    Vector3 playerPos = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
                   
    }

    // Update is called once per frame
    void Update()
    {
 

        if (transform.position.x > 8.89f)
        {
            playerPos.y = transform.position.y;

            playerPos.x = transform.position.x + (2* -8.89f);
            
            transform.position = playerPos;
        }
        else if (transform.position.x < -8.89f)
        {
            playerPos.y = transform.position.y;
            playerPos.x = transform.position.x + (2 * 8.89f);
            transform.position = playerPos;
        }
     
    }
}
