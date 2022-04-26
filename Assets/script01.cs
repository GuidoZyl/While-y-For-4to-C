using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btn_Click()
    {
        int counter = 1;
        while (counter <= 100)
        {
            Debug.Log(counter);
            counter++;
        }
    }
}
