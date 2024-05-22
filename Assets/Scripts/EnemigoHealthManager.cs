using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemigoHealthManager : MonoBehaviour
{
    public Slider slider;
    public int salud=100;
    public void HacerPupa(int pupa){
        salud-=pupa;
        slider.value = salud;
    }
}
