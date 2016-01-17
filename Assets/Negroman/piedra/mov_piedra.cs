using UnityEngine;
using System.Collections;

public class mov_piedra : MonoBehaviour
{



    void Start()
    {


    }
    void Update()
    {
        Destroy(gameObject, 3f);
    }
    void OnCollisionEnter2D(Collision2D Other)
    {
       if (Other.gameObject.tag == "enemy1" || Other.gameObject.tag == "enemy2")
        Destroy(gameObject);
        }
    }
