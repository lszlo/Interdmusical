using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    public GameObject nota;
    GameObject GameController;
    public ParticleSystem particle;
  



    Animator animacionBoton;
    public string tecla;

    private void Start()
    {
        animacionBoton = GetComponent<Animator>();
        GameController = GameObject.Find("GameController");
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
        
        
        nota.GetComponent<Animator>().SetTrigger("DestruirNota");
        nota = null;
        GameController.GetComponent<GameController>().SumaPuntos();
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
            GameController.GetComponent<GameController>().ReinicioDerrota();

        }
        else
        {
            GameController.GetComponent<GameController>().ReinicioStreak();
        }
    }
    
}
