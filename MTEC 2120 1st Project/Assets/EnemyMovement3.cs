using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement3 : MonoBehaviour
{

    Vector3 positionOffset;

    // Start is called before the first frame update
    void Start()
    {
        positionOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 
            Mathf.Sin(Time.time) * -3, 
            0) 
            + positionOffset;
    }
}
