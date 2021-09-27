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
        rb.transform.rotation = new Quaternion(rb.transform.rotation.x, camara.transform.rotation.y, rb.transform.rotation.z, camara.transform.rotation.w);
    }

    private void FixedUpdate()
    {
        
    }
    void Update()
    {
        Vel.x = rb.velocity.x;
        Vel.z = rb.velocity.z;

        if (Input.GetMouseButton(1))
        {
            /*
            //rb.transform.rotation = new Quaternion(rb.transform.rotation.x, camara.transform.rotation.y, rb.transform.rotation.z, camara.transform.rotation.w);
            float rotacion = camara.transform.rotation.eulerAngles.y;
            if (Vector3.Project(rb.transform.forward, Vector3.forward) != Vector3.Project(camara.transform.forward, Vector3.forward))
            {

                //rb.transform.Rotate(new Vector3(0, VelocidadRotacion * 0.00000001f * Time.deltaTime, 0), rotacion);
                rb.AddRelativeTorque(new Vector3(0, VelocidadRotacion, 0), ForceMode.Force);
            }
            else rb.rotation = Quaternion.identity; */
            //Quaternion camRot = new Quaternion(rb.transform.rotation.x, camara.transform.rotation.y, rb.transform.rotation.z, rb.transform.rotation.w);

            //rb.MoveRotation(camRot);

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
