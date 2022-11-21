using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculosController : MonoBehaviour
{

    
    public int Velocidad;

    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {

        this.transform.Translate(Vector2.left * Time.deltaTime * Velocidad);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }

}



