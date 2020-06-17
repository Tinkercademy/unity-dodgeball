using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallExplosionScript : MonoBehaviour
{
	//create a public GameObject for the explosion object
	public GameObject explosion;

	//instructions on creating explosions
	//use the OnCollisionEnter function
	//use collision.collider.tag to check if what you've collided into is the player
	//use instantiate to create the explosion
	void OnCollisionEnter(Collision collision) {
		if (collision.collider.tag == "Player") {
			Instantiate(explosion, transform.position, transform.rotation);
		}
	}	
}
