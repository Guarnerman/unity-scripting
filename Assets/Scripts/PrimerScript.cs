using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerScript : MonoBehaviour
{
    public int x;
    public int y;

    public float z = 0.1f;
    public string nombre = "Papatzuli";
    public bool encender = false ;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("r: " + 3 + 5);
        
        Debug.Log(z + y);
        Debug.Log(nombre);
        Debug.Log(encender);
        Debug.LogFormat("Mi nombre es {0}, mi edad es {1} y mi posición es {2}°", nombre, x, y);
        Prueba();
        //x += 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        x++;
        Debug.Log(x);
    }

    void Prueba()
    {
        Debug.Log(x + y);
    }
}
