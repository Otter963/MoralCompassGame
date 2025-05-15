using UnityEngine;
using UnityEngine.UIElements;

public class OfficeScenarioManager : MonoBehaviour
{
    //the below can be changed when a good format for the moral compass is figured out upon feedback after CPA2

    [SerializeField] private GameObject defaultCompassSprite;
    [SerializeField] private GameObject badCompassSprite;
    [SerializeField] private GameObject middleCompassSprite;
    [SerializeField] private GameObject goodCompassSprite;

    public void OfficeChoiceOne()
    {
        defaultCompassSprite.SetActive(false);
        badCompassSprite.SetActive(true);
    }

    public void OfficeChoiceTwo()
    {
        defaultCompassSprite.SetActive(false);
        middleCompassSprite.SetActive(true);
    }

    public void OfficeChoiceThree()
    {
        defaultCompassSprite.SetActive(false);
        goodCompassSprite.SetActive(true);
    }
}
