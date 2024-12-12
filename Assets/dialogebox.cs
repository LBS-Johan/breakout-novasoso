using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class dialogebox : MonoBehaviour
{
    static public TextMeshProUGUI diaBox;
    // Start is called before the first frame update
    void Start()
    {
        diaBox = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (detectplayer.playernear == false)
        {

            diaBox.text = "";
        }
    }
}
