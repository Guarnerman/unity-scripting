using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorMonedas : MonoBehaviour
{
    public static int cestaMoneda = 0;
  

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
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log(cestaMoneda);
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        ContadorMonedas.cestaMoneda--;
        Debug.Log(cestaMoneda);

        
    }
}
