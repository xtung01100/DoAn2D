using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public GameObject pointM;
    public GameObject pointN;
    private Rigidbody2D rig2D;
    //private Animator ani;
    private Transform currentPoint;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();
        //ani = GetComponent<Animator>();
        currentPoint = pointN.transform;
        //ani.SetBool("IsRunning", true);

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointN.transform)
        {
            rig2D.velocity = new Vector2(speed, 0);
        }
        else
        {
            rig2D.velocity = new Vector2(-speed, 0);
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointN.transform)
        {
            flip();
            currentPoint = pointM.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointM.transform)
        {
            flip();
            currentPoint = pointN.transform;
        }

    }
    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;

    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointM.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointN.transform.position, 0.5f);
        Gizmos.DrawLine(pointM.transform.position, pointN.transform.position);
    }
}
