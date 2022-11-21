using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EnemigosDestroyer : MonoBehaviour
{

    [UnityTest]
    public IEnumerator EnemigosDest()
    {

        GameObject enemigosPrefab = Resources.Load<GameObject>("Objetos/Obstaculo");
        int enemigosMax = 3;
        int contEnemigos = 0;
        for (int i = 0; i < enemigosMax; i++)
        {
            GameObject enemigos = Object.Instantiate(enemigosPrefab, new Vector2(0, 0), Quaternion.identity);
            contEnemigos++;
            Debug.Log(contEnemigos);
        }
       

        GameObject zona = new GameObject();
        zona.AddComponent<BoxCollider2D>();
        BoxCollider2D collider = zona.GetComponent<BoxCollider2D>();
        collider.isTrigger = true;
        collider.size.Set(2, 5);
        collider.transform.position = new Vector2(-40, 0);
        collider.tag = "Zona";
        collider.name = "DeadZone";

        GameObject[] obst = GameObject.FindGameObjectsWithTag("Obstaculo");
        Assert.AreEqual(3, obst.Length);

        yield return new WaitForSeconds(9f);

        Assert.AreEqual(0, GameObject.FindGameObjectsWithTag("Obstaculo").Length);
       
    }
}
