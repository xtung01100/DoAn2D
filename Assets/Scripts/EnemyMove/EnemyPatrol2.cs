using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol2 : MonoBehaviour
{
    public GameObject pointE;
    public GameObject pointF;
    private Rigidbody2D rig2D;
    private Animator ani;
    private Transform currentPoint;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        currentPoint = pointE.transform;
        ani.SetBool("IsRunning", true);

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointE.transform)
        {
            rig2D.velocity = new Vector2(-speed, 0);
        }
        else
        {
            rig2D.velocity = new Vector2(speed, 0);
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointF.transform)
        {
            flip();
            currentPoint = pointE.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointE.transform)
        {
            flip();
            currentPoint = pointF.transform;
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
        Gizmos.DrawWireSphere(pointE.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointF.transform.position, 0.5f);
        Gizmos.DrawLine(pointE.transform.position, pointF.transform.position);
    }
}
