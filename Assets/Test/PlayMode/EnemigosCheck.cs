using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EnemigosCheck
{

    [UnityTest]
    public IEnumerator EnemigosChecker()
    {
        GameObject enemigosPrefab = Resources.Load<GameObject>("Objetos/Obstaculo");
        int enemigosMax = Random.Range(1, 6);
        int contEnemigos = 0;
        for(int i = 0; i < enemigosMax; i++)
        {
            GameObject enemigos = Object.Instantiate(enemigosPrefab, new Vector2(0, 0), Quaternion.identity);
            contEnemigos++;
            Debug.Log(contEnemigos);
        }

        yield return new WaitForSeconds(5f);
        Assert.AreEqual(enemigosMax, GameObject.FindGameObjectsWithTag("Obstaculo").Length);
        
    }
}
