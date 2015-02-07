using UnityEngine;
using System.Collections;

public class charController : MonoBehaviour {
	
	public GameObject jumpButton;
	public bool hitFloor;

	string test;

	// Use this for initialization
	void Start () {
		test = "no";
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag.Equals("floor"))
			hitFloor = true;
	}
	void OnCollisionExit2D(Collision2D other)
	{
		if(other.gameObject.tag.Equals("floor"))
			hitFloor = false;
	}
}

