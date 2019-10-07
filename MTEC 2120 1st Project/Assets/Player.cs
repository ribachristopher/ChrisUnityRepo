using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   private Rigidbody rb; 



// Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }

    void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.CompareTag ("Enemy")) {
Destroy (gameObject);
	}
   }
}
