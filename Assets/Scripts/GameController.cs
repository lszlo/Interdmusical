using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    Animator animacionInterface;
    public AudioSource audioSource;
    public bool pausa = false;
    public static int score;

    
    static int puntuacion;
    public Text puntuacionText;

    public int numeroVida = 3;
    public int maximoVida = 5;
    public static int vida;
    public Text vidaText;

    public int numeroDerrota = 6; 
    public static int derrota;
    Animator animDerrota;

    public int numeroStreak = 3;
    public static int streak;
    public Text streakText;



    private void Awake()
    {
        animacionInterface = GameObject.Find("UI").GetComponent<Animator>();
        audioSource = GameObject.Find("AudioSource").GetComponent<AudioSource>();
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

        animDerrota = GameObject.Find("Derrota").GetComponent<Animator>();
        streak = 0;
        derrota = 0;
        vida = numeroVida;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log(Time.timeScale);
        vidaText.text = vida.ToString();

        if (derrota >= numeroDerrota)
        {
            vida--;
            
            derrota = 0;
        }

        if (vida == 0)
        {
            Time.timeScale = 0;
            animDerrota.SetBool("MenuDerrotaVisible", true);
        }

        if (streak == 3)
        {
            streak = 0;
            vida++;
        }

        if (vida >= 5)
        {
            vida = maximoVida;
        }
    }
    //poner el scene manager ese arriba UwU 
    public void ReinicioDerrota()
    {
        derrota = 0;
        Time.timeScale = 1;

    }

    public void ReinicioStreak()
    {
        streak = 0;

        derrota++;
        streakText.text = streak.ToString();

        
    }

    public void SumarDerrota()
    {
        derrota++;
    }
    public void SumaPuntos()
    {
        puntuacion++;
        streak++;
        puntuacionText.text = puntuacion.ToString();
        streakText.text = streak.ToString();
    }

   

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
