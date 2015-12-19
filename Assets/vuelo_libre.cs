using UnityEngine;
using System.Collections;

public class vuelo_libre : MonoBehaviour {
	public float velocidad = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void movimiento(){
		float h = Random.Range(-20.0f,45.0f );
		float v = Random.Range(-5.0f, 6.0f );
		Vector2 mov = new Vector2 (h,v)*velocidad*Time.deltaTime;
		//Rigidbody2D.velocity =mov;
		if(h>0){
			transform.localScale = new Vector3(-1,1,1);
		}
		if(h<0){
			transform.localScale = new Vector3(1,1,1);
		}
	}
}
