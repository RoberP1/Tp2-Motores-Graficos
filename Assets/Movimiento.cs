using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimiento : MonoBehaviour
{

    public float velocidad = 1;
    public float VelocidadRotacion = 1;
    public float MaxVel = 3;
    private Rigidbody rb;
    public GameObject camara;
    Vector3 Vel =new Vector3(0,0,0);
    
    


    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }


    void Update()
    {
        Vel.x = rb.velocity.x;
        Vel.z = rb.velocity.z;
        if (Input.GetMouseButton(1))
        {
            rb.transform.rotation = new Quaternion(rb.transform.rotation.x, camara.transform.rotation.y, rb.transform.rotation.z, camara.transform.rotation.w);
        }
        if (Input.GetKey(KeyCode.W) && (Vel.x < MaxVel && Vel.x > -MaxVel))
        {
            rb.transform.rotation = new Quaternion(rb.transform.rotation.x, camara.transform.rotation.y, rb.transform.rotation.z, camara.transform.rotation.w);

           
            rb.AddRelativeForce(Vector3.forward * velocidad, ForceMode.Force);

            //rb.position += transform.forward * velocidad * Time.deltaTime;
        } 
        if (Input.GetKey(KeyCode.S) && (Vel.x < MaxVel && Vel.x > -MaxVel))
        {
            rb.transform.rotation = new Quaternion(rb.transform.rotation.x, camara.transform.rotation.y, rb.transform.rotation.z, camara.transform.rotation.w);

            //rb.position += -transform.forward * velocidad * Time.deltaTime;
            rb.AddRelativeForce(Vector3.forward * -velocidad, ForceMode.Force);

        }
        if (Input.GetKey(KeyCode.D) && (Vel.z < MaxVel && Vel.z > -MaxVel))
        {
            //rb.position += transform.right * velocidad * Time.deltaTime;
            rb.AddRelativeForce(Vector3.right * velocidad, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A) && (Vel.z < MaxVel && Vel.z > -MaxVel))
        {
            //rb.position += -transform.right * velocidad * Time.deltaTime;
            rb.AddRelativeForce(Vector3.right * -velocidad, ForceMode.Force);
        }
       
    }
}
