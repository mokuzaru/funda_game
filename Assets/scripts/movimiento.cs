using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour
{
	[HideInInspector]
	public bool facingRight = true;
	public float moveForce = 365f;			
	public float maxSpeed = 1f;	
	private Animator anim;
    public GameObject target;
    public GameObject piedra;
    public float fuerza;
   
    void Awake()
	{
       
		anim = GetComponent<Animator>();
		
	}
	

    void lanzamiento(GameObject prefab)
    {
        GameObject clone = Instantiate(prefab, target.transform.position, target.transform.rotation) as GameObject;
        
        clone.GetComponent<Rigidbody2D>().AddForce(target.transform.up * fuerza);
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("lanzar", true);
            lanzamiento(piedra);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            anim.SetBool("lanzar", false);
            lanzamiento(piedra);
        }
        float h = Input.GetAxisRaw("Horizontal");


        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.position.x > Screen.width / 2)
            {
                h = 1;
            }
            else {
                h = -1;
            }
        }

        anim.SetFloat("Speed", Mathf.Abs(h));

        if (h * GetComponent<Rigidbody2D>().velocity.x < maxSpeed)

            GetComponent<Rigidbody2D>().AddForce(Vector2.right * h * moveForce);


        if (Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) > maxSpeed)

            GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x) * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (h < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (h > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
   
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemy2")
            Application.LoadLevel("menu");
    }
}

