using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJERCICIO06 : MonoBehaviour
{
    public int num1;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 % 2 == 0)
        {
            Debug.Log(" el número " + num1 + " es par");

        }
        else if (num1 % 2 != 0)
        {
            Debug.Log("el número " + num1 + " es inpar");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
