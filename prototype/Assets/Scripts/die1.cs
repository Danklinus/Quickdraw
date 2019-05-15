using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die1 : MonoBehaviour
{
    public int bob = 16;
    public GameObject GameController;
    public gameController gamController1;
    public Bullets BulletController;
    public Bullets2 BulletController2;
    public int shots = 0;
    private SpriteRenderer shotColor;
    private Color color;



    // Start is called before the first frame update
    void Awake()
    {
        GameController = GameObject.FindGameObjectWithTag("GameController");
        gamController1 = GameController.GetComponent<gameController>();
        BulletController = GameController.GetComponent<Bullets>();
        BulletController2 = GameController.GetComponent<Bullets2>();
        shotColor = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        color = shotColor.color;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    BulletController.canShoot1 = false;

        //    if (BulletController.bullets >= 1)
        //    {

        //        BulletController.bullets -= 1;
        //    }
        //}

        //if (Input.GetMouseButtonDown(1))
        //{
        //    BulletController2.canShoot2 = false;

        //    if (BulletController2.bullets2 >= 1)
        //    {
               
        //        BulletController2.bullets2 -= 1;
        //    }
        //}

    
    }
    

    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (BulletController.bullets >= 1 && BulletController.canShoot1 == false)
            {
                if (shotColor.color == Color.red)
                {
                    return;
                }
                if (shotColor.color == Color.yellow)
                {
                    return;
                }
                if (shotColor.color == Color.blue)
                {
                    shotColor.color = Color.yellow;
                }
                else
                {
                    shotColor.color = Color.red;
                }
                //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                //RaycastHit hit;

                //if (Physics.Raycast(ray, out hit, 100))
                //{
                //    if (hit.collider.tag == "Shot")
                //    {
                //        GetComponent<Collider>().color = Color.red;
                //    }
                //}
                //shotColor.color = Color.red;
                //if (shotColor.color == Color.red)
                //{
                    gamController1.player1score++;
                //}
                //BulletController.bullets -= 10;
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            //    if (shotColor.color == Color.blue)
            //    {
            //        return;
            //    }
            //    if (shotColor.color == Color.yellow)
            //    {
            //        return;
            //    }
            //    if (shotColor.color == Color.red)
            //    {
            //        shotColor.color = Color.yellow;
            //    }
            //    else
            //    {
            //        shotColor.color = Color.blue;
            //    }
            //    //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //    //RaycastHit hit;

            //    //if (Physics.Raycast(ray, out hit, 100))
            //    //{
            //    //    if (hit.collider.tag == "Shot")
            //    //    {
            //    //        GetComponent<Collider>().color = Color.red;
            //    //    }
            //    //}
            //    gamController1.player2score++;

            if (BulletController2.bullets2 >= 1 && BulletController2.canShoot2 == true)
            {
                if (shotColor.color == Color.blue)
                {
                    return;
                }
                if (shotColor.color == Color.yellow)
                {
                    return;
                }
                if (shotColor.color == Color.red)
                {
                    shotColor.color = Color.yellow;
                }
                else
                {
                    shotColor.color = Color.blue;
                }
                //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                //RaycastHit hit;

                //if (Physics.Raycast(ray, out hit, 100))
                //{
                //    if (hit.collider.tag == "Shot")
                //    {
                //        GetComponent<Collider>().color = Color.red;
                //    }
                //}
                //shotColor.color = Color.blue;
                gamController1.player2score++;
                //BulletController2.bullets2 -= 10;
            }
        }

    }


}
