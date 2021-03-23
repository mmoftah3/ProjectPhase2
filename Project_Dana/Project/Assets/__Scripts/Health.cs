using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //declaring variables
    public GameObject health1, health2, health3, gameOver;
    public static int heart;

    // Start is called before the first frame update
    void Start()
    {
        heart = 3;
        health1.gameObject.SetActive(true);
        health2.gameObject.SetActive(true);
        health3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    void Update()
    {
        if (heart == 3)
        {
            health1.gameObject.SetActive(true);
            health2.gameObject.SetActive(true);
            health3.gameObject.SetActive(true);
            gameOver.gameObject.SetActive(false);

        }

        else if (heart == 2)
            {
                health1.gameObject.SetActive(true);
                health2.gameObject.SetActive(true);
                health3.gameObject.SetActive(false);
            gameOver.gameObject.SetActive(false);

        }
        else if (heart == 1)
        {
            health1.gameObject.SetActive(true);
            health2.gameObject.SetActive(false);
            health3.gameObject.SetActive(false);
            gameOver.gameObject.SetActive(false);

        }
        else if (heart == 0)
        {
            health1.gameObject.SetActive(false);
            health2.gameObject.SetActive(false);
            health3.gameObject.SetActive(false);
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    
}
