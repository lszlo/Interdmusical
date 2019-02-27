using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    public GameObject nota;
    static int puntuacion;
    public Text puntuacionText;


    public static int streak;
    public Text streakText;


    Animator animacionBoton;
    public string tecla;
    private void Start()
    {
        animacionBoton = GetComponent<Animator>();
        streak = 0;
    }

    
    void Update()
    {
        if (Input.GetKey(tecla))
        {
            TeclaPulsada();
            
        }
    }



    void DestruyeNota()
    {
        Destroy(nota);
        nota = null;
        puntuacion++;
        streak++;
        puntuacionText.text = puntuacion.ToString();
        streakText.text = streak.ToString();

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
        TeclaPulsada();
    }

    void TeclaPulsada()
    {
       // Debug.Log("pulsado" + transform.name);
       
        animacionBoton.SetTrigger("pulsado");

        if (nota != null)
        {
           // Debug.Log("Destruyenota");
            DestruyeNota();
        }
        else
        {
            streak = 0;
            streakText.text = streak.ToString();
        }
    }
}
