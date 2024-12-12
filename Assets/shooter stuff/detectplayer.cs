using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectplayer : MonoBehaviour
{
   Vector3 me;
    public static bool playernear = false;
    // Start is called before the first frame update
    void Start()
    {
        me = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (movement.coconutPos.x>=(me.x-3) && movement.coconutPos.y>=me.y-2 && movement.coconutPos.y<=me.y+2 && movement.coconutPos.x <= me.x + 3)
        {
            playernear = true;
            
        }
        else
        {
            playernear = false;
        }
    }
}
