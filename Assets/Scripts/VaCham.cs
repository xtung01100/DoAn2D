using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Collections;

public class VaCham : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp = 3;
    public int Gold = 0;
    public int Bullet = 0;
    public TextMeshProUGUI GoldText;
    public TextMeshProUGUI BulletText;
    //public TextMeshProUGUI HPText;
    [SerializeField] private Animator ani;

    void Start()
    {
        GoldText.SetText(Gold.ToString());
        //HPText.SetText(hp.ToString());
        BulletText.SetText(Bullet.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Gold"))
        {
            Gold++;
            GoldText.SetText(Gold.ToString());
            Destroy(collision.gameObject);
        }
        //if (collision.CompareTag("Enemy"))
        //{
        //    hp--;
        //    HPText.SetText(hp.ToString());
        //}
        if (collision.CompareTag("Bullet"))
        {
            Bullet++;
            BulletText.SetText(Bullet.ToString());
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Enemy"))
        {
            HealthManager.health--;
        }
        else if (collision.CompareTag("GoldKise"))
        {
            HuVang.goldK--;           
            //Destroy(collision.gameObject);
        }
    }
    //private void OnTriggerEnter2D(Collision2D collision)
    //{
    //    if(collision.CompareTag("Enemy")
    //    {
    //        HealthManager.health--;           
    //    }
    //}

}
