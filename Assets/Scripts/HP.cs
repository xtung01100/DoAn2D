using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHp;
    public int m_curHp;
    private void Awake()
    {
        m_curHp = maxHp;
    }
    //private void Start()
    //{
    //    GUIMng.Ins.DrawHpBarGrid(m_curHp, maxHp);

    //}
    //private void AddHp(int hpToAdd)
    //{
    //    m_curHp += hpToAdd;
    //    m_curHp = Mathf.Clamp(m_curHp, 0, maxHp);
    //    GUIMng.Ins.DrawHpBarGrid(m_curHp, maxHp);

    //}
    //private void TakeDamage(int damage)
    //{
    //    m_curHp -= damage;
    //    m_curHp = Mathf.Clamp(m_curHp, 0, maxHp);
    //    GUIMng.Ins.DrawHpBarGrid(m_curHp, maxHp);
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
