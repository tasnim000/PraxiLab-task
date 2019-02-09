using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material red;
    public Material blue;
    public Material green;
  
    public void RedColor()
    {
        gameObject.GetComponent<Renderer>().material = red;
    }
    public void GreenColor()
    {
        gameObject.GetComponent<Renderer>().material = green;
    }
    public void BlueColor()
    {
        gameObject.GetComponent<Renderer>().material = blue;
    }

}
