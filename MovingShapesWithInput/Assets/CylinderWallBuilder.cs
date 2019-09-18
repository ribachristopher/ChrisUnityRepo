using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderWallBuilder : MonoBehaviour
{
    public GameObject Cylinder;

    void Start()
    {
        BuildAWallAtZ(6);
                
                  }

    void BuildAWallAtZ(float z)
    {
        for (int xPos = 0; xPos < 10; xPos++)
        {
            for (int yPos = 0; yPos < 5; yPos++)
            {
                Instantiate(Cylinder, new Vector3(xPos * 2 - 10, yPos * 1.5f, z), Quaternion.identity);
            }
        }
    }
}

