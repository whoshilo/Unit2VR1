using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcornUI : MonoBehaviour
{
    private int acorns = 0;
    public Text acornText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        acornText.text = "Acorns: " + acorns;

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Acorn")
        {
            acorns = acorns + 1;
        }
    }
}
