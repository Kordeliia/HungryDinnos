using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float downBound = -15f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool cond1 = (transform.position.z > topBound);
        bool cond2 = (transform.position.z < downBound);
        if ( cond1 || cond2)
        {
            Destroy(gameObject);
        }
    }
}
