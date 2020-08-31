using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBall : MonoBehaviour {

	public GameObject ball;

	// Use this for initialization
	void Start () {
		Instantiate(ball, new Vector3(0, 0, 0), Quaternion.identity);

		Destroy(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
