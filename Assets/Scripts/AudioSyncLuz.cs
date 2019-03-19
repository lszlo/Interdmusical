using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncLuz : AudioSyncer
{
    //codigo derivado del audiosyncer para cambiar el color de las luces
    //tabla con los colores
    public Color[] colores;
   //Sobreescribe los datos creados en el audiosyncer del onBeat
    public override void OnBeat()
    {
        base.OnBeat();
        cambiarLuz();


    }
    //Aqui se crea la randomizacion de los colores, cogiendolos con la etiqueta 
    void cambiarLuz()
    {
        GameObject[] luces = GameObject.FindGameObjectsWithTag( "Luz");
       // Debug.Log("cambiandoluces");
       //Bucle for para randomizar los colores
        for (int i = 0; i < luces.Length; i++)
        {
            int indiceColor = Random.Range(0, colores.Length - 1);
            luces[i].GetComponent<SpriteRenderer>().color = colores[indiceColor];
        }
    }

}
