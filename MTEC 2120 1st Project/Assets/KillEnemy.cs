using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
	[SerializeField]Transform spawnPoint;

void OnCollisionEnter(Collision col)
{
	if (col.transform.CompareTag("Player"))
		col.transform.position = spawnPoint.position;
}
}
