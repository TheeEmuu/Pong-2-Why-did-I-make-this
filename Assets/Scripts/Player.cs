using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed = 10.0f;
	private string player;

	// Use this for initialization
	void Start () {
		player = this.name;
	}
	
	// Update is called once per frame
	void Update () {
		float movement = Input.GetAxis(player) * speed;

		movement *= Time.deltaTime;

		float location = this.transform.position.y;

		if(location < 4 && location > -4)
			transform.Translate(0, movement, 0);
		else{
			if(location > 4 && movement < 0)
				transform.Translate(0, movement, 0);
			if(location < -4 && movement > 0)
				transform.Translate(0, movement, 0);
		}
	}
}
