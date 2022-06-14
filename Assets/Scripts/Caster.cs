using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caster : MonoBehaviour
{
    public Vector3 direction = Vector3.up;
    public float maxDistance = 1f;

    private void Update()
    {
        if (Physics.Raycast(transform.position, direction, out RaycastHit hitInfo, maxDistance))
        {
            Debug.Log($"Name: {hitInfo.transform.gameObject.name}");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(transform.position, transform.position + direction * maxDistance);
    }
}
