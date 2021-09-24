using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RecoleccionMoneda : MonoBehaviour
{
    private int coin = 0;
    public Text textoCantidadRecolectados;
    public Text textoGanaste;
    private float FinishT;
    private bool Finish = false;

    void Start()
    {
        
        coin = 0;
        textoGanaste.text = "";
        setearTextos();
    }

    private void Update()
    {
        if (!Finish)
        {
            FinishT = Time.time;
        }
        if (Time.time - FinishT > 10f)
        {
            SceneManager.LoadScene("Inicio", LoadSceneMode.Single);
            FinishT = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Moneda") == true)
        {
            //Destroy(other);
            coin = coin + 1;
            setearTextos();
            other.gameObject.SetActive(false);
        }
    }
    private void setearTextos()
    {
        textoCantidadRecolectados.text = coin.ToString();
        if (coin >= 10)
        {
            textoGanaste.text = "Ganaste!";
            Finish = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Perder")
        {
            
            SceneManager.LoadScene("Inicio", LoadSceneMode.Single);
        }
    }


}
