# ejemplo-sencillo-mvc
Ejemplo sencillo de MVC en Unity3D para estudiantes.

Existe una escena, en ella hay 4 botones que sirven para subir/bajar dos variables. 
El código esta estructurado usando el patrón de diseño (más o menos) MVC (Modelo-Vista-Controlador). 

Tenemos tres Scripts asociados a tres objetos para aumentar su claridad:

* **Modelo**: Posee los valores de las variables y métodos que permiten modificarlos y preguntar por ellos.
* **Controlador**: Ofrece publicamente métodos para subir y bajar esos valores del modelo, es el único que modifica el modelo. Los botones estan usando este controlador.
* **Vista**: Posee referencias a los objetos de pantalla y los mantiene a los valores del modelo, simplemente accede a sus valores.

Por lo tanto, los botones estan conectados al Controlador y los valores de pantalla a la Vista. Estos dos scripts se conectan al Modelo para modificar y consultar el estado.
