using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HuVang : MonoBehaviour
{
    public static int goldK = 3;
    public Image[] goldkise;
    public Sprite fullGold;
    public Sprite c_Gold;

    // Start is called before the first frame update
    private void Awake()
    {
        goldK = 3;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Image img in goldkise)
        {
            img.sprite = c_Gold;
        }
        for(int i = 0; i < goldK; i++)
        {
            goldkise[i].sprite = fullGold;
        }
        
    }
}
