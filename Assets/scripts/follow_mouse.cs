using UnityEngine;
using System.Collections;

public class follow_mouse : MonoBehaviour {
	public static float angle;
	public static Vector3 lookPos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//guarda las coordenadas del mouse en pixeles
		Vector3 coordenadaMouse = Input.mousePosition;
		//dar la diferencia entre la camara y el objeto 
		coordenadaMouse.z = 20f;
		//Toma la coordenada del mouse en pixeles y l trasforma en coordenadas x , y
		Vector3 lookPos = Camera.main.ScreenToWorldPoint(coordenadaMouse);
		//obtiene el vector direccion, magnitud
		lookPos = lookPos - transform.position;
		//se encuentra el angulo de giro desde la posicion del target y del mause, usando tangente
		float angle = (Mathf.Atan2(lookPos.y,lookPos.x)*Mathf.Rad2Deg)-90.0f;
		//gira el objeto x angulos de su eje
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}
}
