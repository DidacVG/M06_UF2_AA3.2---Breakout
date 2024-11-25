using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPala : MonoBehaviour
{
    public float velocidad;
    public bool Pala;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float vertical = 0;
        float horizontal = 0;

        if (Pala)
        {
            vertical = Input.GetAxis("Vertical");
            horizontal = Input.GetAxis("Horizontal");
        }
        transform.position = transform.position + new Vector3(horizontal, vertical, 0) * velocidad * Time.deltaTime;
    }
}
