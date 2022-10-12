using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposicionamiento : MonoBehaviour
{
    private float longuitudPiso;

    void Start()
    {
        BoxCollider2D groundCollider = GetComponent<BoxCollider2D>();
        longuitudPiso = groundCollider.size.x;
    }


    void Update()
    {
        if (transform.position.x < -longuitudPiso)
        {
            transform.Translate(Vector2.right * 2f * longuitudPiso);

        }

    }
}
