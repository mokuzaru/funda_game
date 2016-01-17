using UnityEngine;
using System.Collections;

public class vida : MonoBehaviour {
    public static bool life;
    public GameObject boton;

    void Start () {
        boton.SetActive(false);

    }


    void Update()
    {
        if (life == false)
        {
            Destroy(gameObject);
            boton.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
    public void subir_lvl()
    {
        life = true;
        Time.timeScale = 1.0f;
        Application.LoadLevel("menu");
        boton.SetActive(false);
    }
}
