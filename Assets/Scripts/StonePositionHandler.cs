using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonePositionHandler : MonoBehaviour
{
    private float xTop = 0.7f;
    private float xBottom = 2.47f;
    private float zLeft = 3.31f;
    private float zRight = 0.1f;
    
    Transform t;
    public float fixedRotation = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        //t = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //fix rotation
        //t.eulerAngles = new Vector3 (0, 0, 0);
        
        /*
        // Check for top and button
        if (transform.position.x < xBottom)
        {
            transform.position = new Vector3(xBottom, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xTop)
        {
            transform.position = new Vector3(xTop, transform.position.y, transform.position.z);
        }
        // Check for left and right
        if (transform.position.z < zRight)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRight);
        }

        if (transform.position.z > zLeft)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zLeft);
        }
        */
    }
}
