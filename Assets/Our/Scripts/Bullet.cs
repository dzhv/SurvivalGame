using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float Lifetime = 3.0f;

	void Start(){
		Destroy(gameObject, Lifetime);
	}

	void OnCollisionEnter2D(Collision2D collision){
		Debug.Log ("Guten tag i'm collision");
		var health = collision.collider.GetComponent<Health>();
		if (health != null) {
			health.TakeDamage(1);
		}
	}
}
