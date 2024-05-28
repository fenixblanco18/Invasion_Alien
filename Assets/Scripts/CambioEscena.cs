using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
   
    void OnTriggerEnter(Collider c){

        SceneManager.LoadScene(3);
        
     }
}





