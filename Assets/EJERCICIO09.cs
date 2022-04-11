using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJERCICIO09 : MonoBehaviour
{
    // Start is called before the first frame update
    public string nombre1;
    public double ingreso1;

    public string nombre2;
    public double ingreso2;

    public string nombre3;
    public double ingreso3;
  
    double total;

    void Start()
    {
        total = ingreso1 + ingreso2 + ingreso3;

        double porcentaje1 = ingreso1 * 100 / total;
        double porcentaje2 = ingreso2 * 100 / total;
        double porcentaje3 = ingreso3 * 100 / total;

        Debug.Log(nombre1+ " Capital aportado: $"+ingreso1+ ", porcentaje del capita: %" +porcentaje1 );
        Debug.Log(nombre2 + " Capital aportado: $" + ingreso2 + ", porcentaje del capita: %" + porcentaje2);
        Debug.Log(nombre3 + " Capital aportado: $" + ingreso3 + ", porcentaje del capita: %" + porcentaje3);
        Debug.Log("Monto total aportado: $" + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
