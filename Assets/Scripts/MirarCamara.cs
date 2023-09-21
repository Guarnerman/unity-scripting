using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarCamara : MonoBehaviour
{
    [SerializeField]
    Transform target;

    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(target.position.x, this.transform.position.y, target.position.z);

        transform.LookAt(targetPosition);
    }
}
