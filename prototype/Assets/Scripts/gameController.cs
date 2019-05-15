using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public int player1score;
    public int player2score;
    public static void gamController()
    {
        
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player1score >= 4)
        {
            SceneManager.LoadScene(3);
        }

        if (player2score >= 4)
        {
            SceneManager.LoadScene(4);
        }
    }

   
}
