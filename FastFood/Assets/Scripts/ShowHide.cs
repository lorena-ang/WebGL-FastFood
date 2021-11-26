using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    public GameObject obj;
    private bool show = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            obj.SetActive(show);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            obj.SetActive(!show);
            show = !show;
        }
    }
}
