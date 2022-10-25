using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMath : MonoBehaviour
{
    // Start is called before the first frame update
    int num = 8;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        product();
        Debug.Log(num);
    }
    void product()
    {
        num = num * 2;
    }
}
