using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    public GameObject nota;
    static int puntuacion;
    public Text puntuacionText;
    public ParticleSystem particle;

    public static int derrota;
    Animator animDerrota;

    public static int streak;
    public Text streakText;


    Animator animacionBoton;
    public string tecla;

    private void Start()
    {
        animacionBoton = GetComponent<Animator>();
        animDerrota = GameObject.Find("Derrota").GetComponent<Animator>();
        streak = 0;
        derrota = 0;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(tecla))
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
            particle.Emit(1);
            derrota = 0;
            
        }
        else
        {
            streak = 0;
           
            FuncionDerrota();
            streakText.text = streak.ToString();
        }
    }

    

    void FuncionDerrota ()
    {
        derrota++;
        if (derrota >= 6)
        {
            Time.timeScale = 0;
            animDerrota.SetBool("MenuDerrotaVisible", true);
        }
    }

    public void SumarDerrota()
    {
        derrota++;
    } 
}
