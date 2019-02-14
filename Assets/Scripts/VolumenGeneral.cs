using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumenGeneral : MonoBehaviour
{
    public float volumen;

    AudioSource volumenGeneral;

    // Start is called before the first frame update
    void Start()
    {
        volumenGeneral = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        volumenGeneral.volume = volumen;
    }
}
