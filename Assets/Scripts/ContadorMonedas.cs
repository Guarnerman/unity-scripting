using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorMonedas : MonoBehaviour
{
    public static int cestaMoneda = 0;
    public static bool destruirTotal = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("La moneda ha sido creada");
        ContadorMonedas.cestaMoneda++;
        Debug.Log(cestaMoneda);
    }

    // Update is called once per frame
    void Update()
    {
        if(destruirTotal == true)
        {
            DestruccionTotal();
       }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log(cestaMoneda);
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        ContadorMonedas.cestaMoneda--;
        Debug.Log(cestaMoneda);

        if (ContadorMonedas.cestaMoneda <= 0)
        {
            GameObject[] fireworks = GameObject.FindGameObjectsWithTag("Fireworks");  
            foreach(GameObject firework in fireworks)
            {
                firework.GetComponent<ParticleSystem>().Play();
            }
        }

    }

    void DestruccionTotal()
    {
        Destroy(gameObject);
    }
}
