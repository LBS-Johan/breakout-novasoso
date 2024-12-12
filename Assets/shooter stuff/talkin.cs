using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class talkin : MonoBehaviour
{
    TextMeshProUGUI pressE;
    public GameObject dialogue;
    string hexDia1 = "hey there buddy.";
    string hexDia2 = "i guess the armored core really was forged in the fires of rubicon";
    string hexDia3 = "i guess we really are some kind of league of legends";
    string hexDia4 = "i guess skibidi sigma pomni really was digital fortnite chamba";
    int line;
    // Start is called before the first frame update
    void Start()
    {
        pressE = GetComponent<TextMeshProUGUI>();
        line = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (detectplayer.playernear == true && line<5)
        {
            pressE.text = "Press E to talk";
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (line == 1)
                {
                    dialogebox.diaBox.text = hexDia1;
                }
                if (line == 2)
                {
                    dialogebox.diaBox.text = hexDia2;
                }
                if (line == 3)
                {
                    dialogebox.diaBox.text = hexDia3;
                }
                if (line >= 4)
                {
                    dialogebox.diaBox.text = hexDia4;
                }
                line++;
            }
        }
        else
        {
            pressE.text = " ";
        }
    }
}
