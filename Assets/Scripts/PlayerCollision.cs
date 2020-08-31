using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
	private int speed = 500;

	void OnCollisionEnter(Collision other){
		string parent = this.transform.parent.name;
		string name = other.gameObject.name;

		int player = 1;

		switch(parent){
			case "Player 1":
				player = 1;
				break;
			case "Player 2":
				player = -1;
				break;
		}

		switch(name){
			case "Upper":
				push(new Vector3(player, 1, 0), other.gameObject);
				break;
			case "Middle":
				push(new Vector3(player, 0 , 0), other.gameObject);
				break;
			case "Lower":
				push(new Vector3(player, -1 , 0), other.gameObject);
				break;
		}
	}

	void push(Vector3 direction, GameObject other){
		direction = direction.normalized;

		Rigidbody rb = other.GetComponent<Rigidbody>();

		rb.AddForce(direction * speed);
	}
}
