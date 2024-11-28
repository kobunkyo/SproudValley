using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    //[SerializeField] Rigidbody2D rb;
    //[SerializeField] float moveSpeed = 2f;
    //public float directionChangeInterval = 3f;
    //public float boundaryRadius = 5f;

    //private Vector2 movement;
    //private Vector3 startingPosition;

    //void Start()
    //{
    //    startingPosition = transform.position;
    //    StartCoroutine(ChangeMovementDirection());
    //}

    //void Update()
    //{
    //    transform.Translate(movement * moveSpeed * Time.deltaTime);

    //    //Keep annoyance at boundary
    //    Vector3 distanceFromStart = transform.position - startingPosition;
    //    if (distanceFromStart.sqrMagnitude > boundaryRadius)
    //    {
    //        Vector3 fromOriginToObject = transform.position - startingPosition;
    //        fromOriginToObject *= boundaryRadius / fromOriginToObject.magnitude;
    //        transform.position = fromOriginToObject + startingPosition;
    //    }
    //}

    ////Coroutine -> fungsi dipanggil terus terusan bukan perframe
    //System.Collections.IEnumerator ChangeMovementDirection()
    //{
    //    while (true)
    //    {
    //        float angle = Random.Range(0f, 360f);
    //        movement = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad));

    //        //Wait at interval value to change direction
    //        yield return new WaitForSeconds(directionChangeInterval);
    //    }
    //}

    [SerializeField]
    Animator animator;

    [SerializeField]
    float speed;

    [SerializeField]
    float range;

    [SerializeField]
    float maxDistance;

    Vector2 wayPoint;

    void Start()
    {
        SetNewDestination();
    }

    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayPoint) < range)
        {
            SetNewDestination() ;
        }
    }

    void SetNewDestination()
    {
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
        animator.SetBool("isMove", true);
        Debug.Log(wayPoint);
        Flip();

    }

    void Flip()
    {
        Vector2 scale = transform.localScale;
        if (wayPoint.x < 0)
        {
            scale.x = -1; 
        }
        else
        {
            scale.x = 1;
        }
        transform.localScale = scale;
    }

}
