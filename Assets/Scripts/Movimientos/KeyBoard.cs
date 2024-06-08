using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoard : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("presione la tecla P");
        }
        else if (Input.GetKey(KeyCode.P))
        {
            Debug.Log("estoy presionando la tecla P");
        }
        else if (Input.GetKeyUp(KeyCode.P))
        {
            Debug.Log("deje de presionar la tecla P");
        }
    }
}