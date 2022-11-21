using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeController : MonoBehaviour
{

    public float Potencia = 450;
    Rigidbody2D rb;
    /*public Vector2 movimiento;*/
    GameObject Piso;
    public GameManagerController GameManager;
    bool Saltando = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        Piso = GameObject.FindGameObjectWithTag("Piso");
    }

    // Update is called once per frame
    void Update()
    {
        Saltar();
    }

    
    void Saltar()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Saltando == false)
        {
            Saltando = true;
            rb.AddForce(Vector2.up * Potencia);
           
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstaculo"))
        {
            GameManager.Reiniciar();
        }
        if (collision.collider.CompareTag("Piso"))
        {
            Debug.Log("Tocando Piso");
            Saltando = false;
        }
    }

}
