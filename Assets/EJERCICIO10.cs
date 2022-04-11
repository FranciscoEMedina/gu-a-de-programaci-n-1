using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJERCICIO10 : MonoBehaviour
{
    const int HORA_APERTURA = 10;
    const int HORA_CIERRE = 18;
    public int hora;
    bool estaAbierto = false;
    // Start is called before the first frame update
    void Start()
    {
        if (hora <= 0 || hora >= 25)
        {
            Debug.Log("La hora ingresada no es valida. (variable estaAbierto = " + estaAbierto + ")");
        }
        else if (hora > 18 || hora < 10)
        {
            estaAbierto = false;
            Debug.Log("el estableimiento esta cerrado. (variable estaAbierto = " + estaAbierto+")");
        }

        else if (hora < 18 || hora >= 10)
        {
            estaAbierto = true;
            Debug.Log("el estableimiento esta abierto. (variable estaAbierto = " + estaAbierto + ")");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
