using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn_Destroy : MonoBehaviour
{
    void  OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player2D")
        {
            Destroy(gameObject);
        }
    }
}
