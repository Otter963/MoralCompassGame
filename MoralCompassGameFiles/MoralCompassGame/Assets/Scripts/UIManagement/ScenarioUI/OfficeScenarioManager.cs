using UnityEngine;
using UnityEngine.UIElements;

public class OfficeScenarioManager : MonoBehaviour
{
    //the below can be changed when a good format for the moral compass is figured out upon feedback after CPA2

    [SerializeField] private GameObject defaultCompassSprite;
    [SerializeField] private GameObject badCompassSprite;
    [SerializeField] private GameObject middleCompassSprite;
    [SerializeField] private GameObject goodCompassSprite;
    [SerializeField] private OfficeScenario officeScenario;
    [SerializeField] private GameObject officeScenarioCanvas;

    public void OfficeChoiceOne()
    {
        defaultCompassSprite.SetActive(false);
        middleCompassSprite.SetActive(false);
        goodCompassSprite.SetActive(false);
        badCompassSprite.SetActive(true);
        officeScenario.isOfficeScenarioActive = false;
        officeScenarioCanvas.SetActive(false);
    }

    public void OfficeChoiceTwo()
    {
        defaultCompassSprite.SetActive(false);
        badCompassSprite.SetActive(false);
        goodCompassSprite.SetActive(false);
        middleCompassSprite.SetActive(true);
        officeScenarioCanvas.SetActive(false);
    }

    public void OfficeChoiceThree()
    {
        defaultCompassSprite.SetActive(false);
        badCompassSprite.SetActive(false);
        middleCompassSprite.SetActive(false);
        goodCompassSprite.SetActive(true);
        officeScenarioCanvas.SetActive(false);
    }
}
