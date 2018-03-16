using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] float speed = 8f; 
	[SerializeField] float movableRange = 5.5f;
		
	// Update is called once per frame
	void Update () {
		transform.Translate (Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
		transform.position = new Vector2 (Mathf.Clamp (transform.position.x, -movableRange, movableRange), transform.position.y);
	}
}
