using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol3 : MonoBehaviour
{
    public GameObject pointG;
    public GameObject pointH;
    private Rigidbody2D rig2D;
    private Animator ani;
    private Transform currentPoint;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        currentPoint = pointG.transform;
        ani.SetBool("IsRunning", true);

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointG.transform)
        {
            rig2D.velocity = new Vector2(-speed, 0);
        }
        else
        {
            rig2D.velocity = new Vector2(speed, 0);
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointH.transform)
        {
            flip();
            currentPoint = pointG.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointG.transform)
        {
            flip();
            currentPoint = pointH.transform;
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
        Gizmos.DrawWireSphere(pointG.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointH.transform.position, 0.5f);
        Gizmos.DrawLine(pointG.transform.position, pointH.transform.position);
    }
}
