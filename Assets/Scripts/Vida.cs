using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int puntosVida = 100;

    float distancia;

    int damage = 1;

    [SerializeField]
    private Transform punto1;
    [SerializeField]
    private Transform punto2;

    void Awake()
    {
        punto1 = GameObject.FindGameObjectWithTag("Player").transform;
        punto2 = GameObject.FindGameObjectWithTag("Moco").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(punto1.transform.position, punto2.transform.position);
        Debug.Log(distancia);

        if (distancia <= 2)
        {
            puntosVida--;
            Debug.Log(puntosVida);
        }
    }
}
