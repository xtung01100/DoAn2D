using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol4 : MonoBehaviour
{
    public GameObject pointI;
    public GameObject pointJ;
    private Rigidbody2D rig2D;
    private Animator ani;
    private Transform currentPoint;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        currentPoint = pointI.transform;
        ani.SetBool("IsRunning", true);

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointI.transform)
        {
            rig2D.velocity = new Vector2(-speed, 0);
        }
        else
        {
            rig2D.velocity = new Vector2(speed, 0);
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointJ.transform)
        {
            flip();
            currentPoint = pointI.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointI.transform)
        {
            flip();
            currentPoint = pointJ.transform;
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
        Gizmos.DrawWireSphere(pointI.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointJ.transform.position, 0.5f);
        Gizmos.DrawLine(pointI.transform.position, pointJ.transform.position);
    }
}
