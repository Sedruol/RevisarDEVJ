using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public float pointsOfCoin1 = 10;
    public float pointsOfCoin2 = 25;
    public float pointsOfCoin3 = 50;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            UseSingleton.Instance.AddPoints(pointsOfCoin1);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            UseSingleton.Instance.AddPoints(pointsOfCoin2);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            UseSingleton.Instance.AddPoints(pointsOfCoin3);
        }
    }
}