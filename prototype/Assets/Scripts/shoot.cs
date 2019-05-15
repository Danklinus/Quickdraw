using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject GameController;
    public Bullets BulletController;
    // Start is called before the first frame update
    void Start()
    {
        GameController = GameObject.FindGameObjectWithTag("GameController");
        BulletController = GameController.GetComponent<Bullets>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {

            BulletController.bullets -= 10;
        }
    }

}
