using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public int danyo = 1;
    void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemigoHealthManager>().HacerPupa(danyo);
        }
    }
}
