using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorMunicion : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Caja_Balas;
    void OnTriggerEnter(Collider c){
        if (c.gameObject.name=="cartuchos"){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            Caja_Balas.SetActive(true);
            //3. Añadimos al inventario
            //GetComponent<Inventario>().AddItem(c.gameObject);//Añadir la llave al inventario
        }
    }
}
