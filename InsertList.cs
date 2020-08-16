using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertList : MonoBehaviour
{
    List<string> nombres = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        string[] nombreadd = new string[] { "Messi", "Pepe" };
        nombres.AddRange(nombreadd);
        nombres.ForEach(a => Debug.Log("Jugador :" + a));
        nombres.Insert(1, "Jame R.");
        nombres.ForEach(a => Debug.Log("Jugador :" + a));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
