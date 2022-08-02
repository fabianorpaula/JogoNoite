using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    //criando variavel
    int fabiano = 5;
    public float vinicius = -2f;
    public string variaveltexto = "cavalo";

    // Start is called before the first frame update
    void Start()
    {
        int varlocal = 9;
        transform.position = new Vector3(fabiano, vinicius, varlocal);
    }

    // Update is called once per frame
    void Update()
    {
        if(variaveltexto == "cativante")
        {
            fabiano = fabiano + 2;
        }
        if(variaveltexto == "peixe")
        {
            fabiano = fabiano - 2;
        }
        //float terceirovalor = fabiano + vinicius;
        //transform.position = new Vector3(fabiano, vinicius, terceirovalor);

        if(variaveltexto == "vulcao")
        {
            transform.position = new Vector3(-191f, -69.7f,0);
        }
        if (variaveltexto == "neve")
        {
            transform.position = new Vector3(94.7f, 35.68f, 0);
        }
    }
}
