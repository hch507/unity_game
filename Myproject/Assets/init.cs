using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour
{
    // Start is called before the first frame update
    public static float speed = 1;
    float timer = 0;
    void Start()
    {

    }
    void Update()
    {
        if (speed == 1)
        {
            timer += Time.deltaTime;
            if (timer == 2)
            {
                Debug.Log(timer);
                speed = 1;
                timer = 0;
            }
        }
    }
}
