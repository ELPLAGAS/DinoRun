using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public int fuerzaDeSalto = 3;
    public bool estaSaltando;

    void Start()
    {
    
       estaSaltando = false;

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && estaSaltando == false) 
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, fuerzaDeSalto, 0);
            estaSaltando = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Piso")
        {
            estaSaltando = false;
        }

        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            GameManager.Instance.ShowGameOverScreen();
            Time.timeScale = 0f;
        }
    }

  


}