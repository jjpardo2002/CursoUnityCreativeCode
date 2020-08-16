using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estructuras : MonoBehaviour
{
    int j = 1;
    List<string> nombres = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        string[] nombreadd = new string[] { "Messi", "Pepe" };
        
        nombres.AddRange(nombreadd);
        
        nombres.Add("Jose M");
        nombres.Add("Juan J");
        nombres.Add("Jennifer");

        Debug.Log(nombres[0]);
        foreach(string _nombres in nombres )
        {
            Debug.Log(_nombres);
        }


        foreach (string _nombres in nombres)
        {
            if(_nombres.Equals("Messi"))
            {

                Debug.Log("El nombre "+_nombres+" Se encontro en la lista");
                Debug.Log(j);
                j += 1;
                break;
                
            }
           
        }

        //Count Muestra cantidad elementos en la lista
        Debug.Log("Cantidad items " + nombres.Count);
        //Clear Limpia el contenido de la lista
        nombres.Clear();
        Debug.Log("Cantidad items " + nombres.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
