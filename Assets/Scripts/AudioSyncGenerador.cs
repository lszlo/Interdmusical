using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncGenerador : AudioSyncer
{
    //codiigo para la generacion de notas al ritmo de la musica, funciona como todos los demas codigos que beben del audiosyncer
    public GameObject nota;
    public float fuerzaNota = 5f;
   
   
   
    
    public override void OnBeat()
    {
        base.OnBeat();
        GenerarNota();
        


    }
    void GenerarNota()
    {
        GameObject notaNueva;
        Rigidbody rbnota;

        notaNueva = Instantiate(nota, transform.position, transform.rotation);
        rbnota = notaNueva.GetComponent<Rigidbody>();
        rbnota.AddForce(notaNueva.transform.forward * fuerzaNota);
    }
}
