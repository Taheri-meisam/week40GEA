using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using UnityEngine.Splines;
using UnityEditor;

[ExecuteInEditMode()]
public class SplineCode : MonoBehaviour
{

    [SerializeField]
    SplineContainer newSplineContiner;
    [SerializeField]
    int splineIndex;
    [SerializeField]
    float speed;
    Unity.Mathematics.float3 position;
    float3 tangent;
    float3 upVector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newSplineContiner.Evaluate(splineIndex, speed, out position, out tangent, out upVector);
        
    }
    public void OnDrawGizmos()
    {
        Handles.matrix = transform.localToWorldMatrix;
        Handles.color = Color.red;
        Handles.SphereHandleCap(0, position, quaternion.identity, 1f, eventType: EventType.Repaint);
    }
}
