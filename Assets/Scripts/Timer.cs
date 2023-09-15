using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float tiempoMaximo = 60f;

    private float contadorAbajo = 0f;

    // Start is called before the first frame update
    void Start()
    {
        contadorAbajo = tiempoMaximo;
        Debug.Log(contadorAbajo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
