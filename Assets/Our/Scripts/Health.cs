using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public int MaxHealth = 5;
	private int currentHealth;

	public Image HealthBar;

	public void Start () {
		currentHealth = MaxHealth;
	}

	public void TakeDamage (int amount) {
		currentHealth -= amount;
		if (currentHealth <= 0) {
			Kill();	
		}

		HealthBar.fillAmount = (float)currentHealth / (float)MaxHealth;
	}

	public void Kill(){
		Destroy(gameObject);
	}
}
