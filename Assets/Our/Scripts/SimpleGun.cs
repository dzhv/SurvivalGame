using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssemblyCSharp;

public class SimpleGun : MonoBehaviour
{
	public Transform BulletPrefab;
	public float Speed;

	void Update(){
		if (Input.GetButtonDown("Fire1")) {
			Shoot();
		}
	}

	public void Shoot()
	{
		var bulletObject = Instantiate(BulletPrefab, transform.position, transform.rotation);
		var bulletBody = bulletObject.GetComponent<Rigidbody2D> ();

		var mouseWorldPosition = Camera.main.ScreenToWorldPoint(
			Input.mousePosition);

		var direction = (new Vector2(mouseWorldPosition.x, mouseWorldPosition.y) - 
			new Vector2(transform.position.x, transform.position.y)).normalized;	
		bulletBody.velocity = direction * Speed;
	}
}
