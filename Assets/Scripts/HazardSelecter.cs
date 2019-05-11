using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HazardSelecter : MonoBehaviour
{
    Image m_Image;
    public Sprite selectedHazard;
    public Sprite[] hazardList;
    public bool hazardCorrect = true;
    int hazardOption;

    void Start()
    {
        hazardOption = Random.Range(0, 3); // choose a number from 1 to 3
        //Fetch the Image from the GameObject
        m_Image = GetComponent<Image>();
        //Assigning the sprite to the image based off random number
        m_Image.sprite = hazardList[hazardOption];
    }
}