using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    public static ReadInput singleton { get; private set; }

    public float speed;
    public float timeSpawn;
    public Vector3 finalDistance;
    private void Awake()
    {
        singleton = this;
    }
    public void ReadInputSpeed(string text)
    {
        speed = float.Parse(text);
    }
    public void ReadInputTimeSpawn(string text) 
    {
        timeSpawn = float.Parse(text);
    }
    public void ReadInputDistance(string x)
    {
        finalDistance.x = float.Parse(x);
    }
}
