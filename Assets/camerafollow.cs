using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class camerafollow : MonoBehaviour
{
    public UnityEngine.Transform coconut;
    public Vector3 velocity;
    private void Start()
    {
        
    }
    void Update()
    {
        Vector3 mirroredPosition = coconut.position;
        mirroredPosition.z = -10;
        transform.position = Vector3.SmoothDamp(transform.position, mirroredPosition, ref velocity, 0.3f);
        int bomb = 3;
        if (bomb == 2)
        {
            transform.position = new Vector3(mirroredPosition.x, transform.position.y, -10);
        }
    }
    
}

