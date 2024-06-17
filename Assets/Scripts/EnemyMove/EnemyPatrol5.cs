using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol5 : MonoBehaviour
{
    public GameObject pointK;
    public GameObject pointL;
    private Rigidbody2D rig2D;
    private Animator ani;
    private Transform currentPoint;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        currentPoint = pointK.transform;
        ani.SetBool("IsRunning", true);

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointK.transform)
        {
            rig2D.velocity = new Vector2(-speed, 0);
        }
        else
        {
            rig2D.velocity = new Vector2(speed, 0);
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointL.transform)
        {
            flip();
            currentPoint = pointK.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointK.transform)
        {
            flip();
            currentPoint = pointL.transform;
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
        Gizmos.DrawWireSphere(pointK.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointL.transform.position, 0.5f);
        Gizmos.DrawLine(pointK.transform.position, pointL.transform.position);
    }
}
