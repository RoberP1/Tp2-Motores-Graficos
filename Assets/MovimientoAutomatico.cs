using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAutomatico : MonoBehaviour
{
    public bool tengoQueBajar = false;
    public float rapidez = 1;
    public float MaxArriba = 5;
    public float MaxAbajo = 2;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (transform.position.y >= MaxArriba)
        {
            tengoQueBajar = true;
        }
        if (transform.position.y <= MaxAbajo)
        {
            tengoQueBajar = false;
        }

        if (tengoQueBajar)
        {
            Bajar();
        }
        else
        {
            Subir();
        }

    }

    void Subir()
    {
        //transform.position += transform.up * rapidez *Time.deltaTime ;
        //rb.velocity = transform.up * rapidez;
        rb.MovePosition(transform.position + transform.up * rapidez * Time.deltaTime * 2);
        
    }

    void Bajar()
    {
        //transform.position -= transform.up * rapidez * Time.deltaTime;
        //rb.velocity = -transform.up * rapidez;
        rb.MovePosition(transform.position - transform.up * rapidez * Time.deltaTime * 2);
    }

}
