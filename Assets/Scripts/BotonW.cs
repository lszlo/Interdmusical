using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonW : MonoBehaviour
{

    private GameObject nota;
    

    // Update is called once per frame
    void Update()
    {
        if (nota != null && Input.GetKey(KeyCode.W))
        {
            NewMethod();
        }
           

    }

    private void NewMethod()
    {
        DestruyeNota();
    }

    void DestruyeNota()
    {
        Destroy(nota);
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Nota"))
        {
            nota = col.gameObject;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Nota"))
        {
            nota = null;
        }
    }
}
