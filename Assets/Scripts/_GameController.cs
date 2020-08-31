using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _GameController : MonoBehaviour {
	public GameObject MakeBall;
	public Text p1Display, p2Display;
	public AudioClip score;

	private AudioSource source;
	private int p1Score, p2Score;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();

		p1Score = 0;
		p2Score = 0;

		Instantiate(MakeBall, Vector3.zero, Quaternion.identity);
	}

	public void Score(int player){
		source.PlayOneShot(score);
		
		if(player == 1)
			p1Score++;
		if(player == 2)
			p2Score++;
		
		p1Display.text = p1Score.ToString();
		p2Display.text = p2Score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
