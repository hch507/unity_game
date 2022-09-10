using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpBell : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject ItemSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "bird")
        {
            ItemSound.GetComponent<AudioSource>().Play();
            Score.score += 3;
            Destroy(this.gameObject);// 2초후 새로 제거
        }
    }
}
