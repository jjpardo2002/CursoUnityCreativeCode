using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listasPart3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> numeros = new List<int>(new int[] { 1, 5, 120 });
        int indice = numeros.IndexOf(5);
        Debug.Log("Indice :" + indice);

        int indiceN = numeros.IndexOf(50);
        Debug.Log("Indice :" + indiceN);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
