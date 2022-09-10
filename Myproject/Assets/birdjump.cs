using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class birdjump : MonoBehaviour
{
    Rigidbody2D rb; //새의 중력 컴포넌트를 받아올 변수
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // rb에 중력 컴포넌트를 받아옴
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //computer에서의 마우스 클릭은 모바일에서의 터치
        {
            rb.velocity = Vector2.up * jumpPower; //(0,1)*3 y쪽방향으로 속도(힘)을 가함 점프!
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Score.score > Score.bestscore)
        {
            Score.bestscore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
