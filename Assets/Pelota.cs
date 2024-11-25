using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class Pelota : MonoBehaviour
{
    public float velocidad;
    public Vector2 direccion;
    public int vidas;

    // Start is called before the first frame update
    private void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3)direccion * velocidad * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pared")
        {
            direccion = new Vector2(-direccion.x, direccion.y);
        }

        if (collision.gameObject.tag == "Techo")
        {
            direccion = new Vector2(direccion.x, -direccion.y);
        }

        if (collision.gameObject.tag == "Bloques 1")
        {
            Vector2 dir = transform.position - collision.transform.position;
            dir.Normalize();
            direccion = dir;
        }

        if (collision.gameObject.tag == "Bloques 2")
        {
            Vector2 dir = transform.position - collision.transform.position;
            dir.Normalize();
            direccion = dir;
        }
        if (collision.gameObject.tag == "Bloques 3")
        {
            Vector2 dir = transform.position - collision.transform.position;
            dir.Normalize();
            direccion = dir;
        }
        if (collision.gameObject.tag == "Bloques 4")
        {
            Vector2 dir = transform.position - collision.transform.position;
            dir.Normalize();
            direccion = dir;
        }
        if (collision.gameObject.tag == "Bloques 5")
        {
            Vector2 dir = transform.position - collision.transform.position;
            dir.Normalize();
            direccion = dir;
        }
        if (collision.gameObject.tag == "Bloques 6")
        {
            Vector2 dir = transform.position - collision.transform.position;
            dir.Normalize();
            direccion = dir;
        }

        if (collision.gameObject.tag == "Pala")
        {
            Vector2 dir = transform.position - collision.transform.position;
            dir.Normalize();
            direccion = dir;
        }

        if (collision.gameObject.tag == "Suelo")
        {
            if (vidas > 0   )
            {
                Spawn();
                vidas = vidas - 1;
            }
            else
            {
                Destroy(gameObject);
            }
            
        }
    }
    void Spawn()
    {
        transform.position = new Vector3(0, 0);
        float x = Random.Range(-1f, 1f);
        if (x > 0)
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        float y = Random.Range(-1f, 0);
        direccion = new Vector2(x, y);
    }
}
