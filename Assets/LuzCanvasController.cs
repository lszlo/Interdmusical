using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuzCanvasController : AudioSyncer
{
    public Color[] colores;

    public override void OnBeat()
    {
        base.OnBeat();
        cambiarLuz();


    }
    //hola
    void cambiarLuz()
    {
        GameObject[] luces = GameObject.FindGameObjectsWithTag("Luz");
        // Debug.Log("cambiandoluces");

        for (int i = 0; i < luces.Length; i++)
        {
            int indiceColor = Random.Range(0, colores.Length - 1);
            luces[i].GetComponent<Image>().color = colores[indiceColor];
        }
    }

}
