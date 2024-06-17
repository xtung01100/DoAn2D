using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpItem : MonoBehaviour
{
    // Start is called before the first frame update
    public Image hpImg;
    public Sprite hpActive;
    public Sprite hpInacActive;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateUI(bool isActive = true)
    {
        if (!hpImg) return;
        if (isActive)
        {
            hpImg.sprite = hpActive;
        }
        else
        {
            hpImg.sprite = hpInacActive;
        }
    }
}
