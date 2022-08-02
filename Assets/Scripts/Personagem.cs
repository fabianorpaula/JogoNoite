using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personagem : MonoBehaviour
{

    public Rigidbody2D Corpo;
    private SpriteRenderer Sp_imagem;
    private Animator Anim;
    private float velocidade_queda;
    //Para pulo Simples
    private bool pode_pular = false;
    //para bloquear o dano
    public bool pode_apanhar = true;
    //Para pulo Duplo
    private int qtd_pulos = 0;

    /// <summary>
    /// Dados Personagem
    /// </summary>
    public int sangue = 100;
    
    
    
    
    
    
    
    
    
    public Image imgHP;

    //Ataques
    public GameObject MeuAtaque;

    void Start()
    {
        Sp_imagem = GetComponent<SpriteRenderer>();
        Anim = GetComponent<Animator>();
    }
    void Update()
    {
        Mover();
        Pular();
        imgHP.rectTransform.sizeDelta = new Vector2(sangue*10, 100);

        if(Input.GetKeyDown(KeyCode.Z) || Input.GetMouseButtonDown(0))
        {
            Anim.SetTrigger("Ataquei");
            
        }

    }
    public void AtaqueDistancia()
    {
        GameObject AtkD = Instantiate(MeuAtaque, transform.position, Quaternion.identity);
        Destroy(AtkD, 2f);
    }

    public void TomouDano()
    {
        sangue = sangue - 1;
    }

    //Todas as ações de movimento vertical
    void Mover()
    {
        float movX = Input.GetAxis("Horizontal") * 4;
        velocidade_queda = Corpo.velocity.y;
        if (velocidade_queda < -5f)
        {
            velocidade_queda = -5f;
        }
        Corpo.velocity = new Vector2(movX, velocidade_queda);

        if (movX < 0)
        {
            Sp_imagem.flipX = true;
            Anim.SetBool("Corrida", true);
        }
        else if (movX > 0)
        {
            Sp_imagem.flipX = false;
            Anim.SetBool("Corrida", true);
        }
        else
        {
            Anim.SetBool("Corrida", false);
        }
    }
   
    void Pular()
    {
        //Se uso pulo simples
        //if(pode_pular == true)
        //Se usar pulo duplo
        if (qtd_pulos > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                //Se usar pulo simples
                //pode_pular = false;
                //Se usar pulo duplo
                qtd_pulos--;
                Corpo.AddForce(transform.up * 300);
            }
        }
        
    }

    //Gatilho Para Pular
    void OnTriggerEnter2D(Collider2D tocou)
    {
        //Se tocar o objeto Pode Pular
        if(tocou.gameObject.tag == "Chao")
        {   
            //Pulo simples
            pode_pular = true;
            //Pulo duplo
            qtd_pulos = 2;
            Debug.Log("Toquei o Chao");
        }
        
    }

    

    private void OnCollisionStay2D(Collision2D colidir)
    {
        if(colidir.gameObject.tag == "Inimigo")
        {
            if (pode_apanhar)
            {
                TomouDano();
                pode_apanhar = false;
                Anim.SetTrigger("Apanhou");
            }
            
        }
    }

    public void PassouDano()
    {
        pode_apanhar = true;
    }


   

}
