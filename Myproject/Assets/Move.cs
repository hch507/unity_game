using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    int way = 0;
    void Start()
    {
        transform.position = new Vector3(2, Random.Range(3f, -2.5f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.position += Vector3.left * init.speed * Time.deltaTime;//(-1,0,0), 프레임 보정


    }
}
