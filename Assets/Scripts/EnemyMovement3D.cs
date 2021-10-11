using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement3D : MonoBehaviour
{
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ex = transform.position.x;
        float px = player.transform.position.x;
        float ez = transform.position.z;
        float pz = player.transform.position.z;

        float distx = ex - px;
        float distz = ez - pz;

        if (distx > 3)
        {
            transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
        if (distx < -3)
        {
            transform.localRotation = Quaternion.Euler(0, 270, 0);
        }

        if (distz > 3)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (distz < -3)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }


    }
}
