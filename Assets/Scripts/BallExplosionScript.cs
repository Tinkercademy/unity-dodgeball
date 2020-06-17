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
		if (collision.collider.tag == "Ball") {
			Explosion(collision.GetContact(0).point);
		}
		else if (collision.collider.tag == "Player") {
			Explosion(collision.GetContact(0).point);
			collision.rigidbody.AddExplosionForce(100f, collision.GetContact(0).point, 100f, 0f, ForceMode.Force);
			collision.gameObject.GetComponent<PlayerHealthScript>().AdjustHp(-1);
		}	
	}
	
	void Explosion(Vector3 point) {
		Instantiate(explosion, transform.position, transform.rotation);
		float explosionForce = 100f;
		float explosionRadius = 100f;
		gameObject.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, point, explosionRadius, 0f, ForceMode.Force);
	}
}
