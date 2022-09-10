using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMove : MonoBehaviour
{
    // Start is called before the first frame update
    int way = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (way == 0)
        {
            transform.position += Vector3.left * 1 * Time.deltaTime;//(-1,0,0), 프레임 보정
            if (transform.position.x < -3.5) {
                transform.position += Vector3.right * 1 * Time.deltaTime;
            }
        }
        
    }
}
