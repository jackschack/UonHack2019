using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedHazard : MonoBehaviour
{
    Image m_Image;
    public GameObject hazardObject;
    public int hazard;

    void Start()
    {
        //Fetch the Image from the GameObject
        m_Image = GetComponent<Image>();
    }
    void OnMouseDown()
    {
        hazardObject.GetComponent<HazardSelecter>();
    }
}