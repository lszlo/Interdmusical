using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDestruirMusica : MonoBehaviour
{

    public GameObject musicPlayer;
   void Awake()
    {
        //Cuando carga escena  busca si hay un MUSIC
        musicPlayer = GameObject.Find("MUSIC");
        if (musicPlayer == null)
        {
            //Si el oobjeto no esxiste hace lo siguiente:
            //1. Establece el objeto al que se adjunta este script como reproductor de música
            musicPlayer = this.gameObject;
            //2. Renombrar esto a MUSIC
            musicPlayer.name = "MUSIC";
            //3. Poner que no se borre cuando se cambia de escena 
            DontDestroyOnLoad(musicPlayer);
        }
        else
        {
            if (this.gameObject.name != "MUSIC")
            {
               //Reinicia la musica
                Destroy(this.gameObject);
            }
        }
    }
}
