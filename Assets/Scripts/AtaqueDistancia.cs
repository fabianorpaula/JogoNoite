using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueDistancia : MonoBehaviour
{
    private Rigidbody2D CorpoDoAtk;
    // Start is called before the first frame update
    void Start()
    {
        CorpoDoAtk = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CorpoDoAtk.velocity = new Vector2(6, 0);
    }

    private void OnCollisionEnter2D(Collision2D colidiu)
    {
        if(colidiu.gameObject.tag == "Inimigo")
        {
            Destroy(colidiu.gameObject);
            Destroy(this.gameObject);
        }
    }
}
