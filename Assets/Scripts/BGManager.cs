using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGManager : MonoBehaviour
{
    public Renderer bgRenderer;

    
        
    
   
    void Update()
    {
        if(bgRenderer != null)
        {
            bgRenderer.material.mainTextureOffset = new Vector2(0f, 0.1f * Time.time);
        }
    }
}
