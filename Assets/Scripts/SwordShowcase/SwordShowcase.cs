using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages the showcase of sword cards, displaying information such as name, description, and 3D model.
/// </summary>
public class SwordShowcase : MonoBehaviour {
    [SerializeField] private CardData[] cardData;
    [SerializeField] private TMP_Text cardNameText, cardDescription;
    [SerializeField] private Image cardIcon;
    [SerializeField] private GameObject cardCamera;

    private GameObject currentSword;
    private int currentCardData = 0;

    private void Start() {
        changeSword();
    }

    /// <summary>
    /// Changes the displayed sword card, updating information and 3D model.
    /// </summary>
    private void changeSword() {
        Destroy(currentSword);
        cardCamera.transform.localPosition = cardData[currentCardData].getCameraPosition();
        cardIcon.sprite = cardData[currentCardData].getCardType();
        cardNameText.text = cardData[currentCardData].getCardName();
        cardDescription.text = cardData[currentCardData].getDescription();
        currentSword = Instantiate(cardData[currentCardData].getCardPrefab());
        currentSword.transform.position = Vector3.zero;
        RenderSettings.skybox = cardData[currentCardData].getSkybox();
    }

    /// <summary>
    /// Displays the next sword card in the showcase.
    /// </summary>
    public void nextSword() {
        currentCardData++;
        if (currentCardData >= cardData.Length) {
            currentCardData = 0;
        }
        changeSword();
    }

    /// <summary>
    /// Displays the previous sword card in the showcase.
    /// </summary>
    public void prevSword() {
        currentCardData--;
        if (currentCardData < 0) {
            currentCardData = cardData.Length - 1;
        }
        changeSword();
    }
}