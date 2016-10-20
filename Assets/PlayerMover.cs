using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour {

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = new Vector2 (0, 0);	
		if (Input.GetKey ("w")) {
			rb.velocity = new Vector2(rb.velocity.x, 1f);
		}
		if (Input.GetKey ("d")) {
			rb.velocity = new Vector2(1f, rb.velocity.y);
		}
		if (Input.GetKey ("s")) {
			rb.velocity = new Vector2(rb.velocity.x, -1f);
		}
		if (Input.GetKey ("a")) {
			rb.velocity = new Vector2(-1f, rb.velocity.y);
		}
	}
}
