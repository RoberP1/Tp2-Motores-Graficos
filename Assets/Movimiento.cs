using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimiento : MonoBehaviour
{

    public float velocidad = 1;
    public float VelocidadRotacion = 1;
    private Rigidbody rb;
    public GameObject camara;
    


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }


    void Update()
    {

        
        if (Input.GetMouseButton(1))
        {
            rb.transform.rotation = new Quaternion(rb.transform.rotation.x, camara.transform.rotation.y, rb.transform.rotation.z, camara.transform.rotation.w);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.transform.rotation = new Quaternion(rb.transform.rotation.x, camara.transform.rotation.y, rb.transform.rotation.z, camara.transform.rotation.w);
            
            
            rb.position += transform.forward * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.transform.rotation = new Quaternion(rb.transform.rotation.x, camara.transform.rotation.y, rb.transform.rotation.z, camara.transform.rotation.w);

            rb.position += -transform.forward * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.position += transform.right * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.position += -transform.right * velocidad * Time.deltaTime;
        }
        /*if (Input.GetKey(KeyCode.E))
        {
            rb.transform.Rotate(0, VelocidadRotacion, 0);
            
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.transform.Rotate(0, -VelocidadRotacion, 0);
            
        }*/


    }
    Vector3 ConseguirPerpendicular(Vector3 direccion)
    {
        return Vector3.Cross(direccion, Vector3.up);
    }
}
