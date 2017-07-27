using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vista : MonoBehaviour {

    public Text textoValorAzul;
    public Text textoValorRojo;
    public ModeloDatos datos;
	
	// Update is called once per frame
	void Update () {
        textoValorAzul.text = datos.getAzul().ToString();
        textoValorRojo.text = datos.getRojo().ToString();
    }
}
