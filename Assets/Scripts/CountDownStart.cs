using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownStart : MonoBehaviour
{
    public Text contador;
    private float tiempo = 3f;

    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        contador.text = " " + tiempo.ToString("f0");
    }
}
