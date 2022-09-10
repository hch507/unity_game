using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCabbage : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * init.speed * Time.deltaTime;//(-1,0,0), 프레임 보정
    }
}
