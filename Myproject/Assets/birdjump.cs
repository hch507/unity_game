using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class birdjump : MonoBehaviour
{
    Rigidbody2D rb; //���� �߷� ������Ʈ�� �޾ƿ� ����
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // rb�� �߷� ������Ʈ�� �޾ƿ�
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //computer������ ���콺 Ŭ���� ����Ͽ����� ��ġ
        {
            rb.velocity = Vector2.up * jumpPower; //(0,1)*3 y�ʹ������� �ӵ�(��)�� ���� ����!
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
