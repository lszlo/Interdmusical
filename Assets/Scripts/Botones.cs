using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    private GameObject nota;
    int puntuacion;
    public Text puntuacionText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DestruyeNota()
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
}
