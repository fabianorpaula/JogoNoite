using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula09_08 : MonoBehaviour
{
    public float velocidade = 0.01f;
    
    void Update()
    {
        if (transform.position.x > 10)
        {
            velocidade = -0.01f;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (transform.position.x < -10)
        {
            velocidade = 0.01f;
            transform.localScale = new Vector3(1, 1, 1);
        }

        transform.position = new Vector3(transform.position.x + velocidade, 0, 0);   
    }
}
