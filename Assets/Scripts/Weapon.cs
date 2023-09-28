using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string fireAxis = "Fire1";

    public float reloadDelay = .2f;

    public bool canFire = true;

    public Transform[] weaponTransform;

    void FixedUpdate()
    {
        if (Input.GetButtonDown(fireAxis) && canFire)
        {
            foreach (Transform t in weaponTransform)
            {
                MannagerAmmo.SpawnAmmo(t.position, t.rotation);
            }

            canFire = false;

            Invoke("EnableFire", reloadDelay);
        }

    }

    void EnableFire()
    {
        canFire = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
