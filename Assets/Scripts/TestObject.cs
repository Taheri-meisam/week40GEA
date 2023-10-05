using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Player")]
public class TestObject : ScriptableObject
{
    public float speed = 1.0f;
    public float rotationSpeed = 2.0f;
    public Vector3 pos = Vector3.zero;
    public Material mat;

    public void initObject()
    {
        Debug.Log("Player :" + this.name + "placed at :"+ pos);
    }

}
