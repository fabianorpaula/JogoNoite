using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaImagem : MonoBehaviour
{
    public Sprite imagem1;
    public Sprite imagem2;
    public Sprite imagem3;
    public int contador = 0;
    public SpriteRenderer MostradorDeImagem;


    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {


            contador = contador + 1;
            if (contador < 25)
            {
                MostradorDeImagem.sprite = imagem1;

            }
            if (contador < 50)
            {
                if (contador > 25)
                {
                    MostradorDeImagem.sprite = imagem2;
                }
            }
            if (contador < 75)
            {
                if (contador > 50)
                {
                    MostradorDeImagem.sprite = imagem3;
                }
            }
            if (contador > 75)
            {
                contador = 0;
            }
            transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3(-1, 1, 1);
            transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
        }
    }
}
