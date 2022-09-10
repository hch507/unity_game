using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpCab : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "bird")
        {
            GetComponent<AudioSource>().Play();
            
            Score.score += 3;
            Destroy(this.gameObject);// 2초후 새로 제거
        }
    }
}
