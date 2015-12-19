using UnityEngine;
using System.Collections;

public class mov_piedra : MonoBehaviour {
	
	public Vector2 velocity;
	public Rigidbody2D rb2D;

	void Start() {
		rb2D = GetComponent<Rigidbody2D>();

	}
	void FixedUpdate() {

		//rb2D.MoveRotation (rb2D.rotation + follow_mouse.angle * Time.fixedDeltaTime);

		rb2D.MovePosition (rb2D.position + velocity * Time.fixedDeltaTime);
		//rb2D.velocity = new Vector2 (follow_mouse.lookPos.x, follow_mouse.lookPos.y);
	}

}
