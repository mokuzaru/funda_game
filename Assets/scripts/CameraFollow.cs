using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public Vector2 maxXAndY;		
	public Vector2 minXAndY;		
	
	private Transform player;

    void Awake ()
	{
	    
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	

	
	
	void LateUpdate ()
	{
		TrackPlayer();
	}
	
	
	void TrackPlayer ()
	{

		float targetX = transform.position.x;
		float targetY = transform.position.y;
		
		targetX = player.position.x;
		
		targetY = player.position.y;
		
		targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
		targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);
		
		transform.position = new Vector3(targetX, targetY, transform.position.z);
	}
}