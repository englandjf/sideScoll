using UnityEngine;
using System.Collections;

public class leftScript : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0)
		{
			foreach(Touch touch in Input.touches){
				Vector3 wp = Camera.main.ScreenToWorldPoint(touch.position);
				Vector2 touchPos = new Vector2(wp.x, wp.y);
				if (collider2D == Physics2D.OverlapPoint(touchPos))			
				{
					player.rigidbody2D.AddForce(new Vector2(-10,0));
				}
			}
		}
	}
}
