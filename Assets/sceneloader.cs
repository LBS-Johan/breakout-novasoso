using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadMain()
    {
        SceneManager.LoadScene("breakout");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void exit()
    {
        Application.Quit();
    }

}
