using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncLuz : AudioSyncer
{
    public Color[] colores;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnBeat()
    {
        base.OnBeat();
        cambiarLuz();


    }
    //hola
    void cambiarLuz()
    {
        GameObject[] luces = GameObject.FindGameObjectsWithTag( "Luz");
       
        for (int i = 0; i < luces.Length; i++)
        {
            int indiceColor = Random.Range(0, colores.Length - 1);
            luces[i].GetComponent<SpriteRenderer>().color = colores[indiceColor];
        }
    }

}
