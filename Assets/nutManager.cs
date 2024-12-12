using UnityEngine;

public class nutManager : MonoBehaviour
{

    private ballsafetynet ballNet;
    GameObject heart33;
    GameObject heart23;
    GameObject heart13;
    // Start is called before the first frame update
    void Start()
    {
        heart33 = GameObject.Find("healthynut33");
        heart23 = GameObject.Find("healthynut23");
        heart13 = GameObject.Find("healthynut13");
        ballNet = GameObject.Find("ball").GetComponent<ballsafetynet>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ballNet.health <= 2 && heart33 != null)
        {
            Firstnut(heart33);
        }
        if (ballNet.health <= 1 && heart23 != null)
        {
            Secondnut(heart23);
        }
        if (ballNet.health <= 0 && heart13 != null)
        {
            Thirdnut(heart13);
        }

    }
    void Firstnut(GameObject nut)
    {
        RemoveHealthyNut(nut);
    }
    void Secondnut(GameObject nut)
    {
        RemoveHealthyNut(nut);
    }
    void Thirdnut(GameObject nut)
    {
        RemoveHealthyNut(nut);
    }
    void RemoveHealthyNut(GameObject objectToDestroy)
    {
        Destroy(objectToDestroy);
    }

}
