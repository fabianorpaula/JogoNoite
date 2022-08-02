using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    private Rigidbody2D Corpo;
    private float velX = 3;
    private float posInicialX;
    public float posMax;
    public float posMin;
    private SpriteRenderer Sp_Imagem;

    // Start is called before the first frame update
    void Start()
    {
        Corpo = GetComponent<Rigidbody2D>();
        posInicialX = transform.position.x;
        Sp_Imagem = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Corpo.velocity = new Vector2(velX, 0);
        if(velX > 0)
        {
            Sp_Imagem.flipX = false;
        }
        else
        {
            Sp_Imagem.flipX = true;
        }

        if (transform.position.x > posInicialX + 5)
        {
            velX = -3;
        }
        if (transform.position.x < posInicialX - 5)
        {
            velX = 3;
        }
        //Se for no local
        /*
        if(transform.position.x > posMax)
        {
            velX = -3;
        }
        if(transform.position.x < posMin)
        {
            velX = 3;
        }*/
    }
}
