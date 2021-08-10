using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuExitButtonClick : MonoBehaviour
{

    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ExitMenu()
    {
        Time.timeScale = 1;
        Panel.SetActive(false);
    }
}
