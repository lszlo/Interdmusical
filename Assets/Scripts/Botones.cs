using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    private GameObject nota;
    static int puntuacion;
    public Text puntuacionText;


    static int streak;
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
        if (nota != null && Input.GetKey(tecla))
        {
            animacionBoton.SetTrigger("pulsado");
            DestruyeNota();
            
        }
    }



    void DestruyeNota()
    {
        Destroy(nota);
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
        Debug.Log("pulsado"+ transform.name);
        Handheld.Vibrate();
        animacionBoton.SetTrigger("pulsado");
        
        if (nota != null)
        {
            Debug.Log("Destruyenota");
            DestruyeNota();
            streak++;
           
        } else
        {
            streak = 0;
        }
       


    }
}
