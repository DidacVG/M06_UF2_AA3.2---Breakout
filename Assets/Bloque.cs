using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bloque : MonoBehaviour
{
    public GameObject[] Powerup;
    public Puntaje puntaje;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pelota")
        {
            Destroy(gameObject);
            int n = Random.Range(0, Powerup.Length);
            Instantiate(Powerup[n], transform.position, transform.rotation);

            if (gameObject.tag == "Bloques 1")
            {
                puntaje.IncrementarPuntaje(1);
            }
            if (gameObject.tag == "Bloques 2")
            {
                puntaje.IncrementarPuntaje(2);
            }
            if (gameObject.tag == "Bloques 3")
            {
                puntaje.IncrementarPuntaje(3);
            }
            if (gameObject.tag == "Bloques 4")
            {
                puntaje.IncrementarPuntaje(4);
            }
            if (gameObject.tag == "Bloques 5")
            {
                puntaje.IncrementarPuntaje(5);
            }
            if (gameObject.tag == "Bloques 6")
            {
                puntaje.IncrementarPuntaje(6);
            }
        }
    }
}
