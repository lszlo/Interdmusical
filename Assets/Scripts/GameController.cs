using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public Animator animacionInterface;
    public bool pausa = false;
    public int numeroEscena;
    public static int score;
    public AudioSource audioSource;
    // Use this for initialization
    void Start ()
    {
        //audioSource.Play();
      
    }
	
	// Update is called once per frame
	void Update ()
    {
	}
    //poner el scene manager ese arriba UwU 
    public void RecargaNivel()
    {
        SceneManager.LoadScene(numeroEscena);
    }
    public void salirSelector()
    {
        SceneManager.LoadScene("SelectorNiveles");
    }
    public void menuSalir()
    {
        pausa = !pausa;
       // animacionInterface.SetBool("visible", pausa);

        if (!pausa)
        {
            Time.timeScale = 1f;
            audioSource.Play();
           
        }
        else
        {
            audioSource.Pause();
            Time.timeScale = 0f;
           
        }
    }
}
