using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField]
    Transform door;

    [SerializeField]
    Transform openTransform;

    [SerializeField]
    Transform closedTransform;

    [SerializeField]
    float doorSpeed = 1.0F;

    public bool isUnlocked = false;

    Vector3 targetPosition;

    float time;

    private void Start()
    {
        targetPosition = closedTransform.position;
    }

    void Update()
    {
        if(isUnlocked && door.position != targetPosition)
        {
            door.transform.position = Vector3.Lerp(door.transform.position, targetPosition, time);
            time += Time.deltaTime * doorSpeed;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            targetPosition = openTransform.position;
            time = 0;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            targetPosition = closedTransform.position;
            time = 0;
        }
    }
}
