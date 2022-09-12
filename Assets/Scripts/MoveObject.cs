using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    float moveSpeed;
    [SerializeField] Vector3 moveDirection;

    [SerializeField] GameObject stationarySphere;

    [SerializeField] float totalMoveDistance;
    Vector3 startingLocation;   

    void Start()
    {
        moveSpeed = .43f;
        totalMoveDistance = 10f;
        startingLocation = gameObject.transform.position;
    }

    void Update()
    {
        float distanceTraveled = GetDistanceTraveled();

        if (distanceTraveled > totalMoveDistance)
        {
            FlipMoveDirection();
        }

        // MoveObject thisMoveObject = GetComponent<MoveObject>();

        gameObject.transform.Translate(moveDirection * moveSpeed);
    }

    void FlipMoveDirection()
    {
        moveDirection = -moveDirection;
    }

    float GetDistanceTraveled()
    {
        return Vector3.Distance(gameObject.transform.position, startingLocation);
    }
}
