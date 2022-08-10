using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula09_08p2 : MonoBehaviour
{
    //Declarando Variaveis
    public float velocidade = 0.01f;
    public bool cheguei_para_atacar_direita = false;
    public int contador_direita;
    public Sprite atk1;
    public Sprite atk2;
    public Sprite atk3;
    public Sprite andar1;
    public SpriteRenderer mostraImagem;

    void Update()
    {
        if (cheguei_para_atacar_direita == false)
        {
            if (transform.position.x > 10)
            {
                cheguei_para_atacar_direita = true;
                
            }
            if (transform.position.x < -10)
            {
                velocidade = 0.01f;
                transform.localScale = new Vector3(1, 1, 1);
            }

            transform.position = new Vector3(transform.position.x + velocidade, 0, 0);
        }
        else
        {
            if(contador_direita < 50)
            {
                
                mostraImagem.sprite = atk1;
            }
            if(contador_direita < 100)
            {
                if(contador_direita > 50)
                {
                    mostraImagem.sprite = atk2;
                }
            }
            if(contador_direita > 100)
            {
                mostraImagem.sprite = atk3;
            }
            
            contador_direita = contador_direita + 1;
            if(contador_direita > 250)
            {
                velocidade = -0.01f;
                transform.localScale = new Vector3(-1, 1, 1);
                cheguei_para_atacar_direita = false;
                mostraImagem.sprite = andar1;
                contador_direita = 0;
                transform.position = new Vector3(9.9f + velocidade, 0, 0);
            }
        }
    }
}
