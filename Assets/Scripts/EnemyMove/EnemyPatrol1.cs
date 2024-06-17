using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol1 : MonoBehaviour
{
    public GameObject pointC;
    public GameObject pointD;
    private Rigidbody2D rig2D;
    private Animator ani;
    private Transform currentPoint;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        currentPoint = pointC.transform;
        ani.SetBool("IsRunning", true);

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointC.transform)
        {
            rig2D.velocity = new Vector2(-speed, 0);
        }
        else
        {
            rig2D.velocity = new Vector2(speed, 0);
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointD.transform)
        {
            flip();
            currentPoint = pointC.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointC.transform)
        {
            flip();
            currentPoint = pointD.transform;
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
        Gizmos.DrawWireSphere(pointC.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointD.transform.position, 0.5f);
        Gizmos.DrawLine(pointC.transform.position, pointD.transform.position);
    }
}
