using UnityEngine;

public class PersonajeController : MonoBehaviour
{

    public float Potencia = 450;
    Rigidbody2D rb;
    public GameManagerController GameManager;
    public bool Saltando = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Saltar();
    }


    public void Saltar()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Saltando == false)
        {
            Saltando = true;
            rb.AddForce(Vector2.up * Potencia);

        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
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
