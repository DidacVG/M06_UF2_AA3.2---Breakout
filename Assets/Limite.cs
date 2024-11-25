using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float maxY;
    public float minY;
    public float maxX;
    public float minX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY);
        }
        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y);
        }
        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY);
        }
        if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y);
        }
    }
}
