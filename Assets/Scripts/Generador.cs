using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{

	public GameObject nota;
	public float fuerzaNota = 5f;
	public float tiempoMin;
	public float tiempoMax;
	float proximo;


    // Start is called before the first frame update
    void Start()
    {
		proximo = tiempoMin;
    }

    // Update is called once per frame
    void Update()
    {
		if (Time.time > proximo) {
			GenerarNota ();
			proximo = Time.time + Random.Range (tiempoMin, tiempoMax);
		}
    }

	void GenerarNota (){
		GameObject notaNueva;
		Rigidbody rbnota;

		notaNueva = Instantiate (nota, transform.position, transform.rotation);
		rbnota = notaNueva.GetComponent<Rigidbody>();
		rbnota.AddForce (notaNueva.transform.forward * fuerzaNota);
	}
}
