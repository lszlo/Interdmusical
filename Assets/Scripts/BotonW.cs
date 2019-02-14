using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonW : MonoBehaviour
{

    private GameObject nota;
    int puntuacion;
    public Text puntuacionText;


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
        GameController.score++;
        puntuacionText.text = GameController.score.ToString();
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
