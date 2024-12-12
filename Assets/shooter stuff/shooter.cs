using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    Vector3 coconutPos;
    GameObject bulletclone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      if (Input.GetKeyDown(KeyCode.Space))
      {
            bulletclone = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody2D bulletrigidbody = bulletclone.GetComponent<Rigidbody2D>();
            bulletrigidbody.velocity = new Vector2(6, 0);
      }
      if (destroyBullet.bulletPos.y >5 || destroyBullet.bulletPos.y < -5 || destroyBullet.bulletPos.x <-13 || destroyBullet.bulletPos.x >13)
      {
            Destroy(bulletclone);
      }
    }
}
