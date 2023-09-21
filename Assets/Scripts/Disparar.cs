using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject bala;

    [SerializeField]
    private Transform arma;

    void Awake()
    {
        arma = GameObject.FindGameObjectWithTag("Player").transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            GameObject balas = Instantiate(bala);
            balas.transform.position = arma.transform.position;
            Destroy(balas, 5.0f);
        }
    }
}
