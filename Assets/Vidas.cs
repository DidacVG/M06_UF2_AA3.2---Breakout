using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    int pelotasIngame;
    bool pelotasActivas;
    public int vidas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pelotasIngame <= 0)
        {
            vidas--;
        }
        if (pelotasActivas == false) 
        {
            vidas--;
        }
    }
    
        
}
