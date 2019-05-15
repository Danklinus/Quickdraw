using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public int bullets = 6;
    public bool canShoot1 = true;
    public static void BulletController()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (bullets <= 5)
            {
                bullets += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            canShoot1 = true;
            //if (bullets <= 1)
            //{
            //    bullets += 9;
            //}
        }

        if (Input.GetMouseButtonDown(0) && canShoot1 == true)
        {
            canShoot1 = false;

            if (bullets >= 1)
            {

                bullets -= 1;
            }
        }

        
    }
}
