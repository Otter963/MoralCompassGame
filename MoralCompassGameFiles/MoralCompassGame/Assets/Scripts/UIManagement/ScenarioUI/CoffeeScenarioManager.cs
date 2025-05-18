using UnityEngine;

public class CoffeeScenarioManager : MonoBehaviour
{
    [SerializeField] private GameObject defaultCompassSprite;
    [SerializeField] private GameObject badCompassSprite;
    [SerializeField] private GameObject middleCompassSprite;
    [SerializeField] private GameObject goodCompassSprite;
    [SerializeField] private CoffeeScenario coffeeScenario;
    [SerializeField] private GameObject coffeeScenarioCanvas;
    [SerializeField] private GameObject interactBoxCollider;

    public void OfficeChoiceOne()
    {
        defaultCompassSprite.SetActive(false);
        goodCompassSprite.SetActive(false);
        middleCompassSprite.SetActive(false);
        badCompassSprite.SetActive(true);
        coffeeScenario.isCoffeeScenarioActive = false;
        coffeeScenarioCanvas.SetActive(false);
        interactBoxCollider.SetActive(false);
    }

    public void OfficeChoiceTwo()
    {
        defaultCompassSprite.SetActive(false);
        badCompassSprite.SetActive(false);
        middleCompassSprite.SetActive(false);
        goodCompassSprite.SetActive(true);
        coffeeScenario.isCoffeeScenarioActive = false;
        coffeeScenarioCanvas.SetActive(false);
        interactBoxCollider.SetActive(false);
    }

    public void OfficeChoiceThree()
    {
        defaultCompassSprite.SetActive(false);
        goodCompassSprite.SetActive(false);
        badCompassSprite.SetActive(false);
        middleCompassSprite.SetActive(true);
        coffeeScenario.isCoffeeScenarioActive = false;
        coffeeScenarioCanvas.SetActive(false);
        interactBoxCollider.SetActive(false);
    }
}
