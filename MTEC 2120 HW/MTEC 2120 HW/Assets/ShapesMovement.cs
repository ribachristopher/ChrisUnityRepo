using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapesMovement: MonoBehaviour
{

// referencing other game objects
public GameObject shape1;
public GameObject shape2;
public GameObject shape3;
public GameObject shape4;
public AudioSource SoundSource;

// setting variable for movement speed
public float speed = 0.2f;
    
// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed;
        }
	   if (Input.GetKey(KeyCode.Space))
	   {
		SoundSource.Play();

	   }
    }
}