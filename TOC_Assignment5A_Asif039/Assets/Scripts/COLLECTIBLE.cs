using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COLLECTIBLE : MonoBehaviour
{
    // Start is called before the first frame update
    public float X;
    public float Y;
    public float Z;
    public float SPEED;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(X*SPEED,Y* SPEED, Z* SPEED);
    }
}
