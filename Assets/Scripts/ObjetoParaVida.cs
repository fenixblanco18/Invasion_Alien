using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoParaVida : MonoBehaviour
{
    [Header("Restablecer Salud Player")]
    public int Curar;
    public int danyo;
    [Header("Tiempo transcurrido entre cada incremento/decremento daño")]
    public float frecuencia;

    private Transform transformPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transformPlayer = other.gameObject.transform;
            InvokeRepeating("HacerDanyo", 0, frecuencia);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CancelInvoke("HacerDanyo");
            // Aquí puedes destruir el objeto una vez que el jugador se aleje.
            Destroy(gameObject);
        }
    }

    private void HacerDanyo()
    {
        transformPlayer.gameObject.GetComponent<PlayerHealthManager>()?.RecibirPupa(danyo);
    }
}
