using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectorNiveles : MonoBehaviour
{
	public int numPaneles = 7;
	RectTransform rt;
	public float ancho;
	Vector3 posInicial;
	Vector3 posDestino;
	public int panelActual = 1;
	public float velocidad = 1;
    // Start is called before the first frame update
    void Start()
    {
		rt = GetComponent<RectTransform> ();
		posInicial = rt.position;

		posDestino = rt.position;
    }

    // Update is called once per frame
    void Update()
    {
		rt.position = Vector3.Lerp (rt.position, posDestino, velocidad);
    }

	public void Siguiente(){
		if (panelActual > numPaneles-1) {
			panelActual = 1;
			posDestino = posInicial;

		} else {
			posDestino = new Vector3 (posInicial.x - ( (panelActual -1) * ancho) - ancho, rt.position.y, rt.position.z);
			panelActual++;
		}
	
	}

	public void Anterior(){
		

		if (panelActual == 1) {
			panelActual = 7;
			posDestino = new Vector3 (posInicial.x - ( (panelActual -2) * ancho) - ancho, rt.position.y, rt.position.z);
		} else {
			panelActual--;
			posDestino = new Vector3 (posInicial.x - ( (panelActual -2) * ancho) - ancho, rt.position.y, rt.position.z);

		}

	}


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

	public void cargarUnbound () {

		SceneManager.LoadScene("Unbound");
	}
}
