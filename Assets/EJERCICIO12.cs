using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJERCICIO12 : MonoBehaviour
{
    public int dado1;
    public int dado2;
    public int dado3;
    // Start is called before the first frame update
    void Start()
    {
        if (dado1 >= 7 || dado2 >= 7 || dado3 >= 7)
        {
            Debug.Log("Los numeros que colocaste no son posibles en el dado que estamos utilizando");
        }
        else if (dado1 == 6 && dado2 == 6 && dado3 == 6)
        {
            Debug.Log("Exelente");
        }

        else if (dado1 == 6 && dado2 == 6 || dado1 == 6 && dado3 == 6|| dado3 == 6 && dado2 == 6)
        {
            Debug.Log("Muy bien");
        }
          else if (dado1 == 6 && dado3 < 6 && dado2 <6|| dado3 == 6 && dado1 < 6 && dado2 < 6 || dado2 == 6 && dado3 < 6 && dado1 < 6) 
        {
            Debug.Log("Regular");
        }

         else if (dado1 < 6 && dado2 < 6 && dado3 < 6)
        {
            Debug.Log("insuficiente");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
