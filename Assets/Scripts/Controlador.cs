using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour {

    public ModeloDatos datos;

    public void subirAzul()
    {
        datos.subirAzul();
    }

    public void subirRojo()
    {
        datos.subirRojo();
    }

    public void bajarAzul()
    {
        datos.bajarAzul();
    }

    public void bajarRojo()
    {
        datos.bajarRojo();
    }


}
