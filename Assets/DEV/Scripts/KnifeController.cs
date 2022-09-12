using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : MonoBehaviour
{
    public float speed;
    public bool allowControl;
    public Transform currentFirstPosition;
    public Transform currentTargetPosition;
    public bool moveToFirstPosition;
    public float moveToFirstPositionSpeed;
    public Collider sliceCollider;
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if (allowControl)
            {
                //If knife is not moving back to first position, move knife to target position while touching
                transform.position += (currentTargetPosition.position - transform.position).normalized * Time.deltaTime * speed;
            }
        }
        if (moveToFirstPosition)
        {
            if (Vector3.Distance(transform.position, currentFirstPosition.position) > .05f)
            {
                //Moving the knife to first position smoothly
                transform.position = Vector3.Lerp(transform.position, currentFirstPosition.position, Time.deltaTime * moveToFirstPositionSpeed);
                //Disabling knife collider's trigger for pushing soap pieces out of surface
                sliceCollider.isTrigger =false;
            }
            else
            {
                //Stop moving to first position and allow control on knife to cut soap
                moveToFirstPosition = false;
                sliceCollider.isTrigger = true;
                allowControl = true;
            }
        }
    }
}
