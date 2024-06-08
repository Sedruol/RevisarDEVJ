using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("presioné el botón izquierdo del mouse");
        }
        else if (Input.GetMouseButton(0))
        {
            Debug.Log("estoy presionando el botón izquierdo del mouse");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("dejé de presionar el botón izquierdo del mouse");
        }
    }
}