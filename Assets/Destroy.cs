using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //en la camara sirve para que no se mezcle la musica del menu inicial 
    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.Find("MUSIC"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
