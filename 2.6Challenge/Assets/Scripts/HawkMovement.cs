using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HawkMovement : MonoBehaviour
{
    Transform hawk;
    Vector2 xMove;
    // Start is called before the first frame update
    void Start()
    {
        hawk = gameObject.transform;
        xMove = new Vector2(1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime);
        transform.Translate(Vector2.down * Time.deltaTime);
    }
}
