using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteNotas : MonoBehaviour
{
    int derrota;
    GameObject GameController;
    // Start is called before the first frame update
    void Start()
    {
        GameController = GameObject.Find("GameController");
       // derrota = GameObject.Find("derrota").GetComponent<int>();
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
            GameController.GetComponent<Botones>().SumarDerrota();
            
        }

    }
}
