using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repaso : MonoBehaviour
{
    public int valor1 = 20;
    public int valor2 = 20;
    public int valor3 = 10;
    public int valor4 = 0;

    int fotogramas = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(valor1 + valor2);
        valor4 = valor1 + valor2;
        Debug.LogFormat("Valor 4: {0}", valor4);
        ConteoFotogramas();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void ConteoFotogramas()
    {
        fotogramas++;
        Debug.Log(fotogramas);
    }
}
