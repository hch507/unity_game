using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBellPepper : MonoBehaviour
{
    // Start is called before the first frame update

    
    float timer = 0;
    public float timediff;
    public GameObject[] Item;
    public static GameObject Item2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime*init.speed;
        if (timer > timediff)
        {
            int ItemIndex = Random.Range(0, 40);
            
            if (ItemIndex >= 38)
            {
                Item2 = Item[1];
            }
            else if(ItemIndex>=0&&ItemIndex<=15)
            {
                Item2 = Item[0];
            }
            else if (ItemIndex >= 16 && ItemIndex <= 30)
            {
                Item2 = Item[2];
            }
            else
            {
                Item2 = Item[3];
            }
            GameObject newItem= Instantiate(Item2);
            newItem.transform.position = new Vector3(7, Random.Range(3f, -2.5f), 0); //파이프 랜덤 생성
            timer = 0;
            
        }
    }
}
