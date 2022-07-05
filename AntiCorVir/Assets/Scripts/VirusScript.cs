using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusScript : MonoBehaviour
{
    
    [SerializeField] private int hp;    
    public Image hpScale;
   
    private void OnMouseUp()
    {
       Destroy(gameObject);
    }
}
