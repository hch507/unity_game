using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    
    float timer=0;
    public float timediff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime*init.speed;
        if (timer > timediff)
        {
            GameObject newPipe = Instantiate(pipe);
            
           // newPipe.transform.position = new Vector3(2, Random.Range(3f, -2.5f), 0); //파이프 랜덤 생성
            timer = 0;
            Destroy(newPipe, 10.0f);// 2초후 새로 생긴 파이프 제거
        }
        
    }
}
