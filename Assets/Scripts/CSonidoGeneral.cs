using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSonidoGeneral : MonoBehaviour
{
    AudioSource sonidoGeneral;

    float volumen = 1f;
    // Start is called before the first frame update
    void Start()
    {
        sonidoGeneral = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       sonidoGeneral.volume = volumen; 
    }

    public void SetVolume (float vol){
        volumen = vol;
    }
}
