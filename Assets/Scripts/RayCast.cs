using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public float rango;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;

        if (Physics.Raycast(transform.position, forward, out hit, rango))
        {
            if (hit.transform.tag == "Moco")
            {
            Debug.DrawRay(transform.position, forward, Color.green);
                hit.transform.gameObject.GetComponent<Animator>().SetTrigger("Attack");
                hit.transform.gameObject.GetComponent<CaminarFrente>().enabled = true;
            }
            else
            {
                hit.transform.gameObject.GetComponent<CaminarFrente>().enabled = false;
            }
        }
    }
}
