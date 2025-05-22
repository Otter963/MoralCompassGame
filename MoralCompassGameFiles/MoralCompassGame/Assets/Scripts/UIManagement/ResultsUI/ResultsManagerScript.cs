using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ResultsManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject resultsCanvasStart;
    [SerializeField] private GameObject resultsCanvasOverview;
    [SerializeField] private OfficeChoiceManager officeChoiceManager;
    [SerializeField] private CoffeeChoiceManager coffeeChoiceManager;
    [SerializeField] private GameObject playerUiCanvas;

    [Header("ResultTexts")]
    [SerializeField] private GameObject goodGoodText;
    [SerializeField] private GameObject goodMiddleText;
    [SerializeField] private GameObject goodBadText;
    [SerializeField] private GameObject middleMiddleText;
    [SerializeField] private GameObject middleGoodText;
    [SerializeField] private GameObject middleBadText;
    [SerializeField] private GameObject badBadText;
    [SerializeField] private GameObject badGoodText;
    [SerializeField] private GameObject badMiddleText;

    [Header("CompassSprites")]
    [SerializeField] private GameObject badCompassSprite;
    [SerializeField] private GameObject badMiddleCompassSprite;
    [SerializeField] private GameObject middleCompassSprite;
    [SerializeField] private GameObject goodMiddleCompassSprite;
    [SerializeField] private GameObject goodCompassSprite;

    public void StartResults()
    {
        resultsCanvasStart.SetActive(false);
        resultsCanvasOverview.SetActive(true);
        playerUiCanvas.SetActive(false);
    }

    public void OverviewResults()
    {
        //Good-Good

        if (officeChoiceManager.officeChoiceThree == true && coffeeChoiceManager.coffeeChoiceTwo == true)
        {
            badCompassSprite.SetActive(false);
            badMiddleCompassSprite.SetActive(false);
            middleCompassSprite.SetActive(false);
            goodMiddleCompassSprite.SetActive(false);
            goodCompassSprite.SetActive(true);
            

            goodGoodText.SetActive(true);
            goodMiddleText.SetActive(false);
            goodBadText.SetActive(false);
            middleMiddleText.SetActive(false);
            middleGoodText.SetActive(false);
            middleBadText.SetActive(false);
            badBadText.SetActive(false);
            badGoodText.SetActive(false);
            badMiddleText.SetActive(false);
        }

        //Good-Middle

        if (officeChoiceManager.officeChoiceThree == true && coffeeChoiceManager.coffeeChoiceThree == true)
        {
            badCompassSprite.SetActive(false);
            badMiddleCompassSprite.SetActive(false);
            middleCompassSprite.SetActive(false);
            goodMiddleCompassSprite.SetActive(true);
            goodCompassSprite.SetActive(false);


            goodGoodText.SetActive(false);
            goodMiddleText.SetActive(true);
            goodBadText.SetActive(false);
            middleMiddleText.SetActive(false);
            middleGoodText.SetActive(false);
            middleBadText.SetActive(false);
            badBadText.SetActive(false);
            badGoodText.SetActive(false);
            badMiddleText.SetActive(false);
        }

        //Good-Bad

        if (officeChoiceManager.officeChoiceThree == true && coffeeChoiceManager.coffeeChoiceOne == true)
        {
            badCompassSprite.SetActive(false);
            badMiddleCompassSprite.SetActive(false);
            middleCompassSprite.SetActive(true);
            goodMiddleCompassSprite.SetActive(false);
            goodCompassSprite.SetActive(false);


            goodGoodText.SetActive(false);
            goodMiddleText.SetActive(false);
            goodBadText.SetActive(true);
            middleMiddleText.SetActive(false);
            middleGoodText.SetActive(false);
            middleBadText.SetActive(false);
            badBadText.SetActive(false);
            badGoodText.SetActive(false);
            badMiddleText.SetActive(false);
        }

        //Middle-Middle

        if (officeChoiceManager.officeChoiceTwo == true && coffeeChoiceManager.coffeeChoiceThree == true)
        {
            badCompassSprite.SetActive(false);
            badMiddleCompassSprite.SetActive(false);
            middleCompassSprite.SetActive(true);
            goodMiddleCompassSprite.SetActive(false);
            goodCompassSprite.SetActive(false);


            goodGoodText.SetActive(false);
            goodMiddleText.SetActive(false);
            goodBadText.SetActive(false);
            middleMiddleText.SetActive(true);
            middleGoodText.SetActive(false);
            middleBadText.SetActive(false);
            badBadText.SetActive(false);
            badGoodText.SetActive(false);
            badMiddleText.SetActive(false);
        }

        //Middle-Good

        if (officeChoiceManager.officeChoiceTwo == true && coffeeChoiceManager.coffeeChoiceTwo == true)
        {
            badCompassSprite.SetActive(false);
            badMiddleCompassSprite.SetActive(false);
            middleCompassSprite.SetActive(false);
            goodMiddleCompassSprite.SetActive(true);
            goodCompassSprite.SetActive(false);


            goodGoodText.SetActive(false);
            goodMiddleText.SetActive(false);
            goodBadText.SetActive(false);
            middleMiddleText.SetActive(false);
            middleGoodText.SetActive(true);
            middleBadText.SetActive(false);
            badBadText.SetActive(false);
            badGoodText.SetActive(false);
            badMiddleText.SetActive(false);
        }

        //Middle-Bad

        if (officeChoiceManager.officeChoiceTwo == true && coffeeChoiceManager.coffeeChoiceOne == true)
        {
            badCompassSprite.SetActive(false);
            badMiddleCompassSprite.SetActive(true);
            middleCompassSprite.SetActive(false);
            goodMiddleCompassSprite.SetActive(false);
            goodCompassSprite.SetActive(false);


            goodGoodText.SetActive(false);
            goodMiddleText.SetActive(false);
            goodBadText.SetActive(false);
            middleMiddleText.SetActive(false);
            middleGoodText.SetActive(false);
            middleBadText.SetActive(true);
            badBadText.SetActive(false);
            badGoodText.SetActive(false);
            badMiddleText.SetActive(false);
        }

        //Bad-Bad

        if (officeChoiceManager.officeChoiceOne == true && coffeeChoiceManager.coffeeChoiceOne == true)
        {
            badCompassSprite.SetActive(true);
            badMiddleCompassSprite.SetActive(false);
            middleCompassSprite.SetActive(false);
            goodMiddleCompassSprite.SetActive(false);
            goodCompassSprite.SetActive(false);


            goodGoodText.SetActive(false);
            goodMiddleText.SetActive(false);
            goodBadText.SetActive(false);
            middleMiddleText.SetActive(false);
            middleGoodText.SetActive(false);
            middleBadText.SetActive(false);
            badBadText.SetActive(true);
            badGoodText.SetActive(false);
            badMiddleText.SetActive(false);
        }

        //Bad-Good

        if (officeChoiceManager.officeChoiceOne == true && coffeeChoiceManager.coffeeChoiceTwo == true)
        {
            badCompassSprite.SetActive(false);
            badMiddleCompassSprite.SetActive(false);
            middleCompassSprite.SetActive(true);
            goodMiddleCompassSprite.SetActive(false);
            goodCompassSprite.SetActive(false);


            goodGoodText.SetActive(false);
            goodMiddleText.SetActive(false);
            goodBadText.SetActive(false);
            middleMiddleText.SetActive(false);
            middleGoodText.SetActive(false);
            middleBadText.SetActive(false);
            badBadText.SetActive(false);
            badGoodText.SetActive(true);
            badMiddleText.SetActive(false);
        }

        //Bad-Middle

        if (officeChoiceManager.officeChoiceOne == true && coffeeChoiceManager.coffeeChoiceThree == true)
        {
            badCompassSprite.SetActive(false);
            badMiddleCompassSprite.SetActive(true);
            middleCompassSprite.SetActive(false);
            goodMiddleCompassSprite.SetActive(false);
            goodCompassSprite.SetActive(false);


            goodGoodText.SetActive(false);
            goodMiddleText.SetActive(false);
            goodBadText.SetActive(false);
            middleMiddleText.SetActive(false);
            middleGoodText.SetActive(false);
            middleBadText.SetActive(false);
            badBadText.SetActive(false);
            badGoodText.SetActive(false);
            badMiddleText.SetActive(true);
        }

    }

    public void RetryGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
