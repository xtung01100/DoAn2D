using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Death : MonoBehaviour
{
    // Start is called before the first frame update
    
   // private Rigidbody2D rb;
    private Animator ani;

    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    void Update()
    {
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Kiểm tra xem nhân vật có nhảy lên đầu quái vật hay không
            if (collision.contacts[0].normal.y < -0.5)
            {
                
                ani.SetTrigger("die");
                GetComponent<Collider2D>().enabled = false;
                Destroy(gameObject, 0f); // Tiêu diệt quái vật
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5f), ForceMode2D.Impulse); // Tăng lực nhảy lên cho nhân vật
            }
            //else
            //{
            //    Debug.Log("Player hit by enemy!");
            //    collision.gameObject.GetComponent<PlayerDeath>().Die(); // Gọi hàm Die() của nhân vật
            //}
        }

    }
}
