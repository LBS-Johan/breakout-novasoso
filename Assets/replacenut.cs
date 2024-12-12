using UnityEngine;

public class replacenut : MonoBehaviour
{
    public GameObject nuttoreplace;
    private Vector3 nuttoreplacePos;
    // Start is called before the first frame update
    void Start()
    {
        nuttoreplacePos = nuttoreplace.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(nuttoreplace == null)
        {
            transform.position = nuttoreplacePos;
        }
    }
}
