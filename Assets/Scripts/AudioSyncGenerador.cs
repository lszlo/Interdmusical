using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncGenerador : AudioSyncer
{
    public GameObject nota;
    public float fuerzaNota = 5f;
   
   
   
    
    public override void OnBeat()
    {
        base.OnBeat();
        GenerarNota();
        Debug.LogWarning("musica");


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
