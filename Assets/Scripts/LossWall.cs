using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossWall : MonoBehaviour {

	public GameObject MakeBall;
	public GameObject GameController;

	void OnCollisionEnter(Collision other){
		Destroy(other.gameObject);

		if(this.name.Equals("Player 1 Wall"))
			GameController.GetComponent<_GameController>().Score(1);
		if(this.name.Equals("Player 2 Wall"))
			GameController.GetComponent<_GameController>().Score(2);

		Instantiate(MakeBall, new Vector3(0, 0, 0), Quaternion.identity);
	}
}
