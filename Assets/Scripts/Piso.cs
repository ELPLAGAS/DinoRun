using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour
{
    private float velocidadPiso = 8f;
    private float longuitudPiso;

    void Start()
    {
        BoxCollider2D groundCollider = GetComponent<BoxCollider2D>();
        longuitudPiso = groundCollider.size.x;
    }


    void Update()
    {
        transform.Translate(Vector3.left * velocidadPiso * Time.deltaTime);

        if(transform.position.x < -longuitudPiso)
        {
           transform.Translate(Vector2.right * 2f * longuitudPiso);

        }

    }
}
