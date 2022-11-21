using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnearObjetos : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obstaculo1;
    int elegirObstaculo;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void SpawnearObstaculo()
    {
        //elegirObstaculo = Random.Range(1, 2);

        Instantiate(obstaculo1, this.transform);
    }


}
