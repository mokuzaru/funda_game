using UnityEngine;
using System.Collections;

public class vuelo_libre : MonoBehaviour {
	public float velocidad;
    
	
    void start()
    {
        
    }
    void FixedUpdate()
    {
        
        transform.Translate(velocidad, 0, 0);
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "piedra"){
            Destroy(gameObject);
        }
        else if (coll.gameObject.tag == "pared2")
        {
            transform.localRotation = Quaternion.Euler(0, 180,0);
            transform.localScale = new Vector3(-1, 1, 1);  
        }else if (coll.gameObject.tag == "pared1")
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
