using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public int CantSaltos = 2;
    public int PotenciaSalto = 1;
    public int SaltosHechos = 0;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SaltosHechos < CantSaltos && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            
            rb.AddForce(0, PotenciaSalto, 0, ForceMode.Impulse);
            SaltosHechos++;
            
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Suelo")
        {
            SaltosHechos = 0;
        }
    }

    
}
