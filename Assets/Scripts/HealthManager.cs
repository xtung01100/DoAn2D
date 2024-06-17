using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public static int health = 3;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    private PlayerDeath playerDeath;

    // Start is called before the first frame update
    private void Awake()
    {
        health = 3;
    }
    void Start()
    {
        playerDeath = FindObjectOfType<PlayerDeath>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Image img in hearts)
        {
            img.sprite = emptyHeart;
        }
        for(int i = 0; i < health; i++)
        {
            hearts[i].sprite = fullHeart;
        }
        if(health <= 0)
        {
            playerDeath.Die();
        }
        
    }
}
