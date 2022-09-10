using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpChi : MonoBehaviour
{
    // Start is called before the first frame update
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "bird")
        {
            if (init.speed == 1)
            {
                Score.score += 7;
                init.speed += 1;
            }
            else
            {
                init.speed -= 1;
            }
        }
        
      
        Destroy(this.gameObject);// 2초후 새로 제거
    }

}
