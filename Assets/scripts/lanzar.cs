using UnityEngine;
using System.Collections;

public class lanzar : MonoBehaviour {
	public GameObject piedra;
	public float speed;

	void lanzamiento(){
		GameObject piedraclone = Instantiate(piedra, transform.position, transform.rotation) as GameObject;
		//piedraclone.GetComponent<Rigidbody2D> ().AddForce (transform.forward*speed );
		//Rigidbody2D rb = GetComponent<Rigidbody2D> (piedraclone);
		//piedraclone.GetComponent<Rigidbody2D> ().velocity = new Vector2 (follow_mouse.lookPos);//.AddForce (punto.transform.forward, ForceMode2D.Impulse);
		
		Debug.Log (piedraclone.transform.position);
		//destroy(piedraclone);
	}
	void Update(){
		if (Input.GetButtonDown ("Fire1")) {
			lanzamiento ();
		}

	}
	void destroy(GameObject piedraclone){
		Destroy(piedraclone, 2.0f);
	}
}
