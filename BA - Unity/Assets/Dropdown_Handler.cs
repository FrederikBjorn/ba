using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown_Handler : MonoBehaviour
{
public GameObject sample_1; 
public GameObject sample_2; 

    public void InputData(int val)

    {
        if (val == 0){
            sample_1.SetActive(false);
            sample_2.SetActive(false);
        }

        if (val == 1){
            sample_1.SetActive(true);
            sample_2.SetActive(false);
        }

        if (val == 2){
            sample_1.SetActive(false);            
            sample_2.SetActive(true);
        }
        
        
    }
}
