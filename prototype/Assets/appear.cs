using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appear : MonoBehaviour
{
    public GameObject shot1;
    public GameObject shot2;
    public GameObject shot3;
    public GameObject shot4;
    public GameObject shot5;
    public GameObject shot6;
    private bool active = false;
    private die shots1;
    private die shots2;
    private die shots3;
    private die shots4;
    private die shots5;
    private die shots6;

    //// Start is called before the first frame update
    void Start()
    {
        shot1 = GameObject.FindGameObjectWithTag("Shot");
        shot2 = GameObject.FindGameObjectWithTag("Shot2");
        shot3 = GameObject.FindGameObjectWithTag("Shot3");
        shot4 = GameObject.FindGameObjectWithTag("Shot4");
        shot5 = GameObject.FindGameObjectWithTag("Shot5");
        shot6 = GameObject.FindGameObjectWithTag("Shot6");
        shots1 = shot1.GetComponent<die>();
        shots2 = shot2.GetComponent<die>();
        shots3 = shot3.GetComponent<die>();
        shots4 = shot4.GetComponent<die>();
        shots5 = shot5.GetComponent<die>();
        shots6 = shot6.GetComponent<die>();

    }

    //// Update is called once per frame
    void Update()
    {
        if (shots1.shots > 0 && shots2.shots > 0 && shots3.shots > 0 && shots4.shots > 0 && shots5.shots > 0 && shots6.shots > 0 && active == false)
        {
            gameObject.SetActive(true);
            active = true;
        }
    }
}
