using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("PlayScene");
        init.speed = 1;
    }
    // Start is called before the first frame update
}
