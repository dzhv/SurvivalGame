using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

	public float MovementSpeed;
	public float RotateSpeed;


	void Update()
	{
		HandleMovement();
		PointCharacterToMouseLocation();
	}

	void HandleMovement(){
		var speed = MovementSpeed * 0.01f;

		var x = Input.GetAxisRaw("Horizontal") * speed;
		var y = Input.GetAxisRaw("Vertical") * speed;

		transform.Translate(x, 0, 0, Space.World);
		transform.Translate(0, y, 0, Space.World);	
	}

	void PointCharacterToMouseLocation(){
		Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(
			Input.mousePosition + Vector3.forward * 10f);

		//Angle between mouse and this object
		float angle = AngleBetweenPoints(transform.position, mouseWorldPosition);

		transform.rotation =  Quaternion.Euler(new Vector3(0f,0f,angle + 90)); // 90 - magic number :(
	}

	float AngleBetweenPoints(Vector2 a, Vector2 b) {
		return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}
