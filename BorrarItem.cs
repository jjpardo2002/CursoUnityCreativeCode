using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarItem : MonoBehaviour
{
    List<int> numeros = new List<int>(new int[] { 1, 5, 120 });
    // Start is called before the first frame update
    void Start()
    {
        numeros.ForEach(a => Debug.Log("Numeros Iniciales :" + a));
        
        numeros.Remove(5);
        
        numeros.ForEach(a => Debug.Log("Numeros Finales :" + a));

        int indiceN = numeros.IndexOf(1);
        numeros.RemoveAt(indiceN);

        numeros.ForEach(a => Debug.Log("Numeros Finales :" + a));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
