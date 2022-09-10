using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSbird : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Sbird;
    float timer = 0;
    public float timediff;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * init.speed;
        if (timer > timediff)
        {
            GameObject newSbird = Instantiate(Sbird);

            newSbird.transform.position = new Vector3(7, Random.Range(3f, -2.5f), 0); //파이프 랜덤 생성
            timer = 0;
            Destroy(newSbird, 10.0f);// 2초후 새로 생긴 파이프 제거
        }
    }
}
