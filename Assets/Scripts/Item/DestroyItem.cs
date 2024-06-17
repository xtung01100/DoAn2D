using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator ani;
    //[SerializeField] private Rigidbody2D rg;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //rg = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ani.SetTrigger("Destroy");
            Destroy(gameObject, 0.5f);
        }
    }
}
