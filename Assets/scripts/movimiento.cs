using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour
{
	[HideInInspector]
	public bool facingRight = true;				
	
	public float moveForce = 365f;			
	public float maxSpeed = 1f;	
	private Animator anim;					
	
	
	void Awake()
	{
		anim = GetComponent<Animator>();
		
	}
	
	void Update(){
		if (Input.GetButtonDown ("Fire1")) {
			anim.SetBool ("lanzar", true);
		} else if (Input.GetButtonUp ("Fire1")) {
			anim.SetBool ("lanzar", false);
		}
	}
	
	
	void FixedUpdate ()
	{

		float h = Input.GetAxisRaw("Horizontal");
		

		if(Input.touchCount > 0) {
			Touch t = Input.GetTouch(0);
			if(t.position.x > Screen.width / 2) {
				h = 1;
			} else  {
				h = -1;
			}
		}

		anim.SetFloat ("Speed", Mathf.Abs (h));

		if(h * GetComponent<Rigidbody2D>().velocity.x < maxSpeed)

			GetComponent<Rigidbody2D>().AddForce(Vector2.right * h * moveForce);
		

		if(Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) > maxSpeed)

			GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x) * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
		

		if(h > 0 && !facingRight)

			Flip();

		else if(h < 0 && facingRight)

			Flip();

		
	}
	
	
	void Flip ()
	{

		facingRight = !facingRight;
		

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
	}
}
