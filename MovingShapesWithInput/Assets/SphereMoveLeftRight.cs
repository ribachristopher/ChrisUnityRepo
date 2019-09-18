using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMoveLeftRight : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == false)
        {
            //Grab original position
            Vector3 SusanTheNextPosition = transform.position;
            //Modify position
            SusanTheNextPosition.x = Mathf.Cos(Time.time) * 3;
            //Apply position
            transform.position = SusanTheNextPosition;
        }
        else
        {
            Debug.Log("I stopped moving for one frame");
        }

    }
}