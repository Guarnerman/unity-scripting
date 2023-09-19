using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ContadorMonedas.cestaMoneda++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
