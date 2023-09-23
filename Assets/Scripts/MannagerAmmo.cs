using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MannagerAmmo : MonoBehaviour
{
    public GameObject ammoPrefab = null;

    public int cargador = 20;

    //Objeto en cola
    public Queue<Transform> ammoQueue = new Queue<Transform>();

    private GameObject[] ammoArray;

    public static MannagerAmmo ammoMannager = null;

    void Awake()
    {
        if(ammoMannager != null)
        {
            Destroy(GetComponent<MannagerAmmo>());
            return;
        }

        ammoMannager = this;

        ammoArray = new GameObject[cargador];

        for (int i = 0; i < cargador; i++)
        {
            GameObject ammo = Instantiate(ammoPrefab, Vector3.zero, Quaternion.identity) as GameObject;
            Transform objectTransform = ammo.GetComponent<Transform>();
            objectTransform.parent = GetComponent<Transform>();

            ammoQueue.Enqueue(objectTransform);
            ammo.SetActive(false);
            ammoArray[i] = ammo;
        }
    }

    public static Transform SpawnAmmo(Vector3 position, Quaternion rotation)
    {
        Transform ammo = ammoMannager.ammoQueue.Dequeue();
        ammo.gameObject.SetActive(true);
        ammo.position = position;
        ammo.localRotation = rotation;

        ammoMannager.ammoQueue.Enqueue(ammo);

        return ammo;
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
