using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	//Update is called before rendering a frame
	//Here goes the game code
	void Update () {
	
	}

	//Is called before any physics calculation
	//Physics code goes here
	void FixedUpdate(){

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rigidbody.AddForce(movement * speed * Time.deltaTime);
	}
}
