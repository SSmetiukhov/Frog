using System;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform frogPos;
    // Start is called before the first frame update
    private void Start()
    {
        SetRatio(9, 16);
    }

    // Update is called once per frame
    private void Update()
    {
        if (frogPos.position.y > transform.position.y)
        {
            
            transform.position = new Vector3(transform.position.x, frogPos.position.y, transform.position.z);
        }
    }
    
    void SetRatio(float w, float h)
    {
        if ((((float)Screen.width) / ((float)Screen.height)) > w / h)
        {
            Screen.SetResolution((int)(((float)Screen.height) * (w / h)), Screen.height, true);
        }
        else
        {
            Screen.SetResolution(Screen.width, (int)(((float)Screen.width) * (h / w)), true);
        }
    }
}
