using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
     // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))  {
GetComponent<Rigidbody>().AddForce (Vector3.up * 500);
    }
  }
}
