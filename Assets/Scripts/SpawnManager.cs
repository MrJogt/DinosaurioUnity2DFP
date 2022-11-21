using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject obstaculo1;
    public Transform spawner1Trans;
    public Transform spawner2Trans;
    private float Temporizador;
    private float TiempoMax;
    int elegirObstaculo;
    int elegirSpawner;

    // Start is called before the first frame update
    void Start()
    {
        spawner1 = GameObject.FindGameObjectWithTag("Spawner1");
        spawner2 = GameObject.FindGameObjectWithTag("Spawner2");
        TiempoMax = 1f;
        spawner1Trans = spawner1.transform;
        spawner2Trans = spawner2.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Temporizador += Time.deltaTime;
        if (Temporizador >= TiempoMax)
        {
            CrearObstaculos();
            randomTiempoMax();
            Temporizador = 0;

        }
    }
    
    void randomTiempoMax()
    {
        TiempoMax = Random.Range(1, 3);
    }

    void CrearObstaculos()
    {        
        elegirSpawner = Random.Range(1, 4);
        Debug.Log(elegirSpawner);
        if (elegirSpawner == 1) { Instantiate(obstaculo1, spawner1Trans.position, spawner1Trans.rotation); }
        if (elegirSpawner == 2) { Instantiate(obstaculo1, spawner2Trans.position, spawner2Trans.rotation); }

    }


}
