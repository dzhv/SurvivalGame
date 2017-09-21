using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int maxHealth;
	private int currentHealth;

	public void Start () {
		currentHealth = maxHealth;
	}

	public void TakeDamage (int amount) {
		currentHealth -= amount;
		if (currentHealth <= 0) {
			Kill();	
		}
	}

	public void Kill(){
		Destroy(gameObject);
	}
}
