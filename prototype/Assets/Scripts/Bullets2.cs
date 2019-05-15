using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets2 : MonoBehaviour
{
    public int bullets2 = 6;
    public bool canShoot2 = true;
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
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (bullets2 <= 5)
            {
                bullets2 += 1;
            }
        }
        if (Input.GetKey("down"))
        {
            canShoot2 = true;
            //if (bullets2 <= 11)
            //{
            //    bullets2 += 9;
            //}
        }

        if (Input.GetMouseButtonDown(1) && canShoot2 == true)
        {
            canShoot2 = false;

            if (bullets2 >= 1)
            {

                bullets2 -= 1;
            }
        }
    }
}
