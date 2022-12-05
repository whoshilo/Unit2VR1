using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    
    public Text healthtext;
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        healthtext.text = "Health " + PlayerMovement.health;

    }
}
