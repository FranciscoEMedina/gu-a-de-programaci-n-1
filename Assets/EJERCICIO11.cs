using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJERCICIO11 : MonoBehaviour
{
    public int YYYYMMDD;
    public string NombreComprador;
    public string NombreProductor;
    public int cantProducto;
    public int precioProducto;
    int total;
    // Start is called before the first frame update
    void Start()
    {
        total = cantProducto * precioProducto;
        Debug.Log("Fecha de compra: " + YYYYMMDD);
        Debug.Log("Nombre del comprador: " + NombreComprador);
        Debug.Log("Producto solicitado: " + NombreProductor);
        Debug.Log("Cantidad solicitada: " + cantProducto);
        Debug.Log("Precio unitario: $" + precioProducto);
        Debug.Log("Total a pagar: " + total);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
