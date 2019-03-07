﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    Animator animacionInterface;
    public AudioSource audioSource;
    public bool pausa = false;
    public static int score;


    private void Awake()
    {
        animacionInterface = GameObject.Find("UI").GetComponent<Animator>();
        audioSource = GameObject.Find("Audio Source").GetComponent<AudioSource>();
        if(audioSource == null)
        {
            Debug.LogError("No se encuentra AudioSource");
        }
    }
    // Use this for initialization
    void Start ()
    {
        //audioSource.Play();
        
        audioSource.Play();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log(Time.timeScale);
	}
    //poner el scene manager ese arriba UwU 
   
    public void salirSelector()
    {
        SceneManager.LoadScene("SelectorNiveles");
    }
    public void menuSalir()
    {
        pausa = !pausa;
       // Debug.Log("Valor pausa:"+pausa);
        if(animacionInterface != null)
        {

            animacionInterface.SetTrigger("visible");
        }
        else
        {
           // Debug.LogError("No se encotró el animator");
        }
        

        if (!pausa)
        {
            //Debug.Log("Saliendo Pausa");
            Time.timeScale = 1f;
            audioSource.UnPause();
           
        }else{
            //Debug.Log("Pausa");
            audioSource.Pause();
            Time.timeScale = 0f;
           
        }
    }

    public void RecargaUnbound()
    {

        SceneManager.LoadScene("Unbound");
    }

    public void RecargaTheThrill()
    {

        SceneManager.LoadScene("TheThrill");
    }

    public void RecargaTheVoyage()
    {

        SceneManager.LoadScene("TheVoyage");
    }

    public void RecargaAureaCarmina()
    {

        SceneManager.LoadScene("AureaCarmina");
    }

    public void RecargaFreedom()
    {

        SceneManager.LoadScene("Freedom");
    }

    public void RecargaMountainKing()
    {

        SceneManager.LoadScene("MountainKing");
    }

    public void RecargaNivelRandom()
    {

        SceneManager.LoadScene("NivelRandom");
    }
}
