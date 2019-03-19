using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    //texto para el ver el tiempo
    public Text tiempoText;
    //tiempo que tiene que transcurrir para acabar el nivel
    public float time = 10;

    //llamo a la animación de la pantalla de victoria
    Animator animacionVictoria;
    //llamo a la animación del menu opciones dentro del nivel
    Animator animacionInterface;
    //hacemos publico el audio para añadirle una pista
    public AudioSource audioSource;
    //parar el tiempo en estado apagado
    public bool pausa = false;
    //numero de puntos
    public static int score;

    //numero de puntos
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


    //cuando inicia la escena empieza la cancion
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
        Time.timeScale = 1;

        animacionVictoria = GameObject.Find("Victoria").GetComponent<Animator>();
        animDerrota = GameObject.Find("Derrota").GetComponent<Animator>();
        streak = 0;
        derrota = 0;
        vida = numeroVida;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //resta tiempo al contador
        time -= Time.deltaTime;
        tiempoText.text = time.ToString("f0");

        //Debug.Log(Time.timeScale);
        vidaText.text = vida.ToString();

        //cuando derrota es mayor del numero seleccionado resta una vida y vuelve a establecerse en 0 para reiniciarse
        if (derrota >= numeroDerrota)
        {
            vida--;
            
            derrota = 0;
        }

        //si vida es 0 el tiempo se para y aparece el menu de derrota
        if (vida == 0)
        {
            Time.timeScale = 0;
            animDerrota.SetBool("MenuDerrotaVisible", true);
        }

        //cuando la racha de puntos alcanza un numero determinado la racha se pone en 0 y suma una vida
        if (streak == 3)
        {
            streak = 0;
            vida++;
        }

        //la vida nunca puede subir de 5 o mas
        if (vida >= 5)
        {
            vida = maximoVida;
        }

        //cuando el tiempo acaba se para el tiempo y aparece el menu de victoria
        if (time <= 0)
        {
            Time.timeScale = 0;
            animacionVictoria.SetBool("AnimacionVisible", true);
        }
    }
    //el contador de derrota se reinicia en 0
    public void ReinicioDerrota()
    {
        derrota = 0;
       

    }

    //el contador de racha se reinicia en 0 y suma 1 al contador de derrota
    public void ReinicioStreak()
    {
        streak = 0;

        derrota++;
        streakText.text = streak.ToString();

        
    }

    //suma 1 al contador de derrota
    public void SumarDerrota()
    {
        derrota++;
    }
    //suma 1 al contador de puntos y al contador de racha
    public void SumaPuntos()
    {
        puntuacion++;
        streak++;
        puntuacionText.text = puntuacion.ToString();
        streakText.text = streak.ToString();
    }

   

    public void salirSelector()
    {
        SceneManager.LoadScene("MenuInicial");
    }

    //para el tiempo para el menu opciones dentro del nivel cuando se sale vuelve el tiempo a la normalidad
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

    //cargar las escenas para los botones
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
