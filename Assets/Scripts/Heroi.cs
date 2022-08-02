using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {
        if(Input.GetKey(KeyCode.H) == true)
        {
            MovePersonagem(0.01f);
            if (Input.GetKey(KeyCode.W) == true)
            {
                LevantarPersonagem(0.01f);
            }
        }
        
       
    }


    void MovePersonagem(float valorX)
    {
        transform.position = new Vector3(transform.position.x + valorX, transform.position.y, transform.position.z);
    }

    void LevantarPersonagem(float valorY)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + valorY, transform.position.z);
    }
}
