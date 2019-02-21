using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CountDownStart : MonoBehaviour
{
    private Text contador;
    private float tiempo = 3f;
    private bool start;
    private bool eventoLanzado = false;

    public UnityEvent OnCountdownEnd;

    // Start is called before the first frame update
    void Start()
    {
        contador = GetComponent<Text>();
        contador.text = " " + tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {

            tiempo -= Time.deltaTime;
            if (tiempo > 0)
                contador.text = " " + tiempo.ToString("f0");
            else{ 
                if (!eventoLanzado)
                    OnCountdownEnd.Invoke();
            }

        }

    }

   public void activador()
    {
        start = true;
    }
}
