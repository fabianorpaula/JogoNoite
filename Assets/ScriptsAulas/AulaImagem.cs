using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaImagem : MonoBehaviour
{
    public Sprite imagem1;
    public Sprite imagem2;
    public Sprite imagem3;

    public SpriteRenderer MostradorDeImagem;

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MostradorDeImagem.sprite = imagem1;
            
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            MostradorDeImagem.sprite = imagem2;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            MostradorDeImagem.sprite = imagem3;
        }
    }
}
