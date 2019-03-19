using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectorNiveles : MonoBehaviour
{
	
    //numero de paneles
	public int numPaneles = 7;
	RectTransform rt;

    //ancho de cada panel
	public float ancho;
	Vector3 posInicial;
	Vector3 posDestino;
    //panel donde estemos ubicados
	public int panelActual = 1;
    //velocidad de la transicion de movimiento de panel a panel
	public float velocidad = 1;
    // Start is called before the first frame update
    void Start()
    {
        //nombramos al componente que contiene la posición y tamaño del panel
		rt = GetComponent<RectTransform> ();

        //ubicación donde se empieza siempre que cargues el menú
		posInicial = rt.localPosition;
        //ubicación donde se va a mover el panel
		posDestino = rt.localPosition;

		
    }

    // Update is called once per frame
    void Update()
    {
    //para que el panel guarde su ubicación actual
		rt.localPosition = Vector3.Lerp (rt.localPosition, posDestino, velocidad);
    }
    //función que hace avanzar los paneles de 1 en uno hacia delante
	public void Siguiente(){
		if (panelActual > numPaneles-1) {
			panelActual = 1;
			posDestino = posInicial;

		} else {
			posDestino = new Vector3 (posInicial.x - ( (panelActual -1) * ancho) - ancho, rt.localPosition.y, rt.localPosition.z);
			panelActual++;
		}
	
	}
    //función que hace retroceder los paneles de 1 en uno hacia atras
	public void Anterior(){
		

		if (panelActual == 1) {
			panelActual = 7;
			posDestino = new Vector3 (posInicial.x - ( (panelActual -2) * ancho) - ancho, rt.localPosition.y, rt.localPosition.z);
		} else {
			panelActual--;
			posDestino = new Vector3 (posInicial.x - ( (panelActual -2) * ancho) - ancho, rt.localPosition.y, rt.localPosition.z);

		}

	}

    //Aqui cargamos las escenas que queremos llamar en los botones
	public void cargarDisco () {

		SceneManager.LoadScene("AureaCarmina");
		
	}

	public void cargarFreedom () {

		SceneManager.LoadScene("Freedom");
	}

	public void cargarMountainKing () {

		SceneManager.LoadScene("MountainKing");
	}

	public void cargarTheThrill () {

		SceneManager.LoadScene("TheThrill");
	}

	public void cargarTheVoyage () {

		SceneManager.LoadScene("TheVoyage");
	}

	public void cargarRandomLevel () {

		SceneManager.LoadScene("NivelRandom");
	}
	public void cargarUnbound () {

		SceneManager.LoadScene("Unbound");
	}

    public void Home()
    {

        SceneManager.LoadScene("MenuInicial");
    }
}
