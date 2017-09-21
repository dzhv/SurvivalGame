using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision){
		Debug.Log ("Guten tag i'm collision");
		var health = collision.collider.GetComponent<Health>();
		if (health != null) {
			health.TakeDamage(1);
		}
	}
}
