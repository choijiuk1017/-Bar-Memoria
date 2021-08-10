using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerButtonClick : MonoBehaviour
{
    public GameObject Page;
    public GameObject Page2;
    public GameObject Page3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PageChange()
    {
        Time.timeScale = 0;
        Page.SetActive(true);
        Page2.SetActive(false);
        Page3.SetActive(false);
    }

}
