using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    public int shots = 0;
    private SpriteRenderer shotColor;
    private Color color;

    // Start is called before the first frame update
    void Awake()
    {
        shotColor = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        color = shotColor.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shotColor.color = Color.red;
            //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit;

            //if (Physics.Raycast(ray, out hit, 100))
            //{
            //    if (hit.collider.tag == "Shot")
            //    {
            //        GetComponent<Collider>().color = Color.red;
            //    }
            //}
            shots++;
        }
    }
}
