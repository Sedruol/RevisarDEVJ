using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSearchPlayer : MonoBehaviour
{
    public float speed = 1;
    //Target
    public GameObject target;
    private float targetPosX;
    //private float targetPosY;
    //Limits
    public float xMax;
    public float xMin;
    public float yMax;
    public float yMin;
    private void MoveCam()
    {
        if (target)
        {
            targetPosX = target.transform.position.x;
            //targetPosY = target.transform.position.y;
            //sin velocidad
            //transform.position = 
            //    new Vector3(targetPosX, targetPosY, transform.position.z);
            //con velocidad
            //transform.position = Vector3.Lerp(transform.position,
            //    new Vector3(targetPosX, targetPosY, transform.position.z), speed);
            //plataformas
            transform.position = Vector3.Lerp(transform.position,
                new Vector3(targetPosX, transform.position.y, transform.position.z), speed);
        }
    }
    private void Update()
    {
        MoveCam();
    }
    private void LateUpdate()
    {
        //top down
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax),
        //    Mathf.Clamp(transform.position.y, yMin, yMax), transform.position.z);
        //plataformas
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax),
            transform.position.y, transform.position.z);
    }
}