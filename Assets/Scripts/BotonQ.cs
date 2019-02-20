using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;



public class BotonQ : MonoBehaviour
{
	
	private GameObject nota;
    int puntuacion;
    public Text puntuacionText;
    


    // Update is called once per frame
    void Update()
    {
		if (nota != null && Input.GetKey (KeyCode.Q)) {
			DestruyeNota ();
		}
    }



	void DestruyeNota(){
		Destroy (nota);
        GameController.score++;
        puntuacionText.text = puntuacion.ToString();
        

    }

	void OnTriggerEnter(Collider col){
		if(col.CompareTag("Nota")){
			nota = col.gameObject;
		}
	}

	void OnTriggerExit(Collider col){
		if(col.CompareTag("Nota")){
			nota = null;
		}
	}
    void OnMouseDown()
    {
        Handheld.Vibrate();
        if (nota != null )
        {
            Debug.Log("Destruyenota");
            DestruyeNota();
        }
        
       
    }

}
