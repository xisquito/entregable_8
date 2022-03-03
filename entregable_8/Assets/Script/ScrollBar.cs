using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBar : MonoBehaviour
{

    private int sizeX = 300;
    private int sizeY = 300;
    private int sizeZ = 300;

    public void ResizeCube(float sizeMultiplier)
        {
        transform.localScale = sizeMultiplier * Vector3.one * 200;

        //transform.localScale = (300, 300, 300);
      
        }
    
}
