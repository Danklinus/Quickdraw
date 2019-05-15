using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die2 : MonoBehaviour
{
    public GameObject GameController;
    public gameController gamController1;
    public Bullets2 BulletController;
    public int shots = 0;
    private SpriteRenderer shotColor;
    private Color color;

    // Start is called before the first frame update
    void Awake()
    {
        GameController = GameObject.FindGameObjectWithTag("GameController");
        gamController1 = GameController.GetComponent<gameController>();
        BulletController = GameController.GetComponent<Bullets2>();
        shotColor = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        color = shotColor.color;
    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    void OnMouseOver()
    {

        //    if (Input.GetMouseButtonDown(0))
        //    {

        //        if (shotColor.color == Color.red)
        //        {
        //            return;
        //        }
        //        if (shotColor.color == Color.yellow)
        //        {
        //            return;
        //        }
        //        if (shotColor.color == Color.blue)
        //        {
        //            shotColor.color = Color.yellow;
        //        }
        //        else
        //        {
        //            shotColor.color = Color.red;
        //        }
        //        //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //        //RaycastHit hit;

        //        //if (Physics.Raycast(ray, out hit, 100))
        //        //{
        //        //    if (hit.collider.tag == "Shot")
        //        //    {
        //        //        GetComponent<Collider>().color = Color.red;
        //        //    }
        //        //}
        //        gamController1.player1score++;



        if (BulletController.bullets2 >= 11)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (shotColor.color == Color.blue)
                {
                    return;
                }
                //if (shotColor.color == Color.yellow)
                //{
                //    return;
                //}
                //if (shotColor.color == Color.red)
                //{
                //    shotColor.color = Color.yellow;
                //}
                //else
                //{
                //    shotColor.color = Color.blue;
                //}
                //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                //RaycastHit hit;

                //if (Physics.Raycast(ray, out hit, 100))
                //{
                //    if (hit.collider.tag == "Shot")
                //    {
                //        GetComponent<Collider>().color = Color.red;
                //    }
                //}
                shotColor.color = Color.blue;
                gamController1.player2score++;
                BulletController.bullets2 -= 10;
            }
        }
    }

}

