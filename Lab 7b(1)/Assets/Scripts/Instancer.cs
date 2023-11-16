using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Instancer : ScriptableObject
{
    public GameObject prefab;


    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance (Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        foreach (var t:Vector3Data in obj.vector3List)
        {
            Instantiate(prefab, t.value, Quaternion.identity);
        } 
    }
}
