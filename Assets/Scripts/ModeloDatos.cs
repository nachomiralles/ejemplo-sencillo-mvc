using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeloDatos : MonoBehaviour {

    private int valorAzul = 0;
    private int valorRojo = 0;
    
    public void subirAzul()
    {
        valorAzul++;
    }

    public void subirRojo()
    {
        valorRojo++;
    }

    public void bajarAzul()
    {
        valorAzul--;
    }

    public void bajarRojo()
    {
        valorRojo--;
    }

    public int getAzul()
    {
        return valorAzul;
    }

    public int getRojo()
    {
        return valorRojo;
    }
}
