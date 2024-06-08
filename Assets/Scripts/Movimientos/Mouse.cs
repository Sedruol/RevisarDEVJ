using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("presion� el bot�n izquierdo del mouse");
        }
        else if (Input.GetMouseButton(0))
        {
            Debug.Log("estoy presionando el bot�n izquierdo del mouse");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("dej� de presionar el bot�n izquierdo del mouse");
        }
    }
}