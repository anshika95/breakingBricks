using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	Vector2 position;
	public float speed;
	void Start () {
		
		position = transform.position; //to store original pos of paddle..den again put changed pos in tranform.pos
	}
	
	// Update is called once per frame
	void Update () {
	
		float moveX = Input.GetAxis ("Horizontal"); //get input from keys and store in movex
		position.x +=moveX * Time.deltaTime * speed;
		position.x = Mathf.Clamp (position.x, -10.0f, 10.0f);
		transform.position = position;

	
	}
}
