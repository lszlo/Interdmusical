using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestruirFicha : MonoBehaviour
{
    Text streakText;
    // Start is called before the first frame update
    void Start()
    {
        streakText = GameObject.Find("StreakPuntos").GetComponent<Text>() ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Nota")
        {
            Destroy(col.gameObject);
            Botones.streak = 0;
            streakText.text = "0";
        }
            
    }
}
