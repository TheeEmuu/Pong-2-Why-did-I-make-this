using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public float speed = 10.0f;
	public AudioClip player, wall;

	private AudioSource source;

	void Awake(){
		source = GetComponent<AudioSource>();
	}

	// Use this for initialization
	void Start () {
		float a = Random.Range(-2f, 2) / 2;
		float b = Random.Range(-2, 2) / 2;

		if(a < 0)
			transform.GetChild(0).transform.Rotate(0, -90, 0);
		if(a > 0)
			transform.GetChild(0).transform.Rotate(0, 90, 0);

		Vector3 direction = new Vector3(a, b, 0);

		Rigidbody rb = GetComponent<Rigidbody>();

		rb.AddForce(direction.normalized * speed);
	}
	
	void OnCollisionEnter(Collision other){
		if(other.gameObject.transform.parent.name.Equals("Player 1")){
			transform.GetChild(0).transform.Rotate(0, 180, 0);
			source.PlayOneShot(player);
		}
		if(other.gameObject.transform.parent.name.Equals("Player 2")){
			transform.GetChild(0).transform.Rotate(0, -180, 0);
			source.PlayOneShot(player);
		}

		if(other.gameObject.tag.Equals("Wall")){
			source.PlayOneShot(wall);
		}
	}
}
