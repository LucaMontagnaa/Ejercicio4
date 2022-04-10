using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    public int num1;
    public int num2;
    int num3;

    void Start()
    {
        num3 = num1 + num2;
        Debug.Log($"La suma de {num1} y {num2}, da como resultado {num3}");
    }
    
    
}
