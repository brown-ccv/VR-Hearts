using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRActions : MonoBehaviour
{
    private Transform old_transform;

    void Start()
    {
        old_transform = GetComponent<Transform>();
    }

    public void SelectElement()
    {
        Debug.Log("HERE 1");
        transform.rotation = old_transform.rotation;
    }

    public void DeselectElement()
    {
        Debug.Log("HERE 2");
        old_transform = GetComponent<Transform>();
    }
}
