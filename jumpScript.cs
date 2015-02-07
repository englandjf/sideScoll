using UnityEngine;
using System.Collections;

public class jumpScript : MonoBehaviour {

	public GameObject player;
	bool jump = false;
	float jumpE;
	string testString;
	charController  playerScript;

	// Use this for initialization
	void Start () {
		testString = "same";
		playerScript = player.GetComponent<charController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0)
		{
			foreach(Touch touch in Input.touches){
				Vector3 wp = Camera.main.ScreenToWorldPoint(touch.position);
				Vector2 touchPos = new Vector2(wp.x, wp.y);
				if (collider2D == Physics2D.OverlapPoint(touchPos) && !jump)		
				{
					jump = true;
					jumpE = Time.time+.1f;
				}
			}
		}

		if(jump && jumpE >= Time.time)
		{
			player.rigidbody2D.AddForce(new Vector2(0,25));
		}
		if(playerScript.hitFloor)
			jump = false;


	}

	void OnGUI()
	{
		GUI.Label(new Rect(0,0,50,50),testString);
	}

	IEnumerator makeJump()
	{
		jump = false;
		yield return new WaitForSeconds(1);

	}






}
