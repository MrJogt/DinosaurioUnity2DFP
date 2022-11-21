using NUnit.Framework;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerChecker : MonoBehaviour
{

    [UnityTest]
    public IEnumerator PlayerUp()
    {

        GameObject personaje = new GameObject();
        personaje.AddComponent<PersonajeController>();
        personaje.AddComponent<Rigidbody2D>();
        personaje.AddComponent<BoxCollider2D>();
        personaje.transform.position = new Vector3(0, 1, 0);
        PersonajeController pj = personaje.GetComponent<PersonajeController>();
        
        pj.Potencia = 500;
        pj.Saltando = false;
        Vector3 posicionInicial = personaje.transform.position;

        GameObject piso = new GameObject();
        piso.AddComponent<BoxCollider2D>();
        BoxCollider2D collider = piso.GetComponent<BoxCollider2D>();
        collider.size.Set(20, 1);
        collider.transform.position = new Vector3(0, 0, 0);
        collider.tag = "Piso";
        collider.name = "Suelo";
        yield return new WaitForSeconds(2f);

        pj.Saltar();

        yield return new WaitForSeconds(2f);
        
        Assert.IsTrue(posicionInicial != personaje.transform.position);




    }
}
