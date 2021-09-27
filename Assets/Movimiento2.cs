using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2 : MonoBehaviour
{
    public Rigidbody Rigid;
    public float MouseSensitivity;
    public float MoveSpeed;
    public GameObject camara;

    void Start()
    {
        Rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetMouseButton(1))
        {
            Rigid.MoveRotation(Rigid.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Mouse X") * MouseSensitivity, 0)));
        }
        if (Input.GetMouseButtonUp(1))
        {
            Rigid.transform.rotation = new Quaternion(Rigid.transform.rotation.x, camara.transform.rotation.y, Rigid.transform.rotation.z, camara.transform.rotation.w);
        }

        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Rigid.AddRelativeForce(new Vector3(horizontalInput, 0, verticalInput) * MoveSpeed);

    }
}
