using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TouchCel : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Debug.Log("Empieza el toque de pantalla");
                    break;
                case TouchPhase.Moved:
                    Debug.Log("El toque de pantalla se encuentra en movimiento");
                    break;
                case TouchPhase.Stationary:
                    Debug.Log("El toque de pantalla se encuentra estático");
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Termina el toque de pantalla");
                    break;
                case TouchPhase.Canceled:
                    Debug.Log("Se canceló el toque de pantalla");
                    break;
            }
        }
    }
}