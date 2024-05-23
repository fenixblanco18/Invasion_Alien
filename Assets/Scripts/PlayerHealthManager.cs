using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    public Image imagenSalud;
    private GameManager gameManager;
    void Start(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();    
    }

    public int Salud=100;
    public void RecibirPupa(int pupa){
        gameManager.DecrementarSalud(pupa);
        Salud-=pupa;
        imagenSalud.fillAmount=Salud/100f;

    //{
       // gameManager.DecrementarSalud(pupa);
        //if (gameManager.salud == 0)
        //{

        if (Salud <= 0) 
        {
            GetComponent<Animator>().SetTrigger("PlayerDeath");
            GetComponent<CharacterController>().enabled = false;
            GetComponent<FPSController>().enabled = false;
            GetComponent<Arma>().enabled = false;
            
            
        }
    }

}
