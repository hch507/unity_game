using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpPipe : MonoBehaviour
{
    public GameObject pipeSoond;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        pipeSoond.GetComponent<AudioSource> ().Play();
        Score.score++;
    }
}
