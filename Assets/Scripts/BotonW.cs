using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class BotonW : MonoBehaviour
{

    private GameObject nota;
    int puntuacion;
    public Text puntuacionText;
    Animator animacionBoton;

    private void Start()
    {
        animacionBoton.GetComponent<Animator>();
        animacionBoton.SetBool("pulsado", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (nota != null && Input.GetKey(KeyCode.Q))
        {
            DestruyeNota();
        }
    }



    void DestruyeNota()
    {
        Destroy(nota);
        GameController.score++;
        puntuacionText.text = puntuacion.ToString();


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

    void OnMouseDown()
    {
        Handheld.Vibrate();
        animacionBoton.SetBool("pulsado", true);
        if (nota != null)
        {
            Debug.Log("Destruyenota");
            DestruyeNota();
        }
    }
}
