using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card")]
public class CardData : ScriptableObject {
    [SerializeField] private string cardName;
    [SerializeField] private string description;
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private Sprite cardType;
    [SerializeField] private Vector3 cameraPositon = new Vector3(0, 0, -3.5f);
    [SerializeField] private Material skybox;

    /// <summary>
    /// Gets the name of the card.
    /// </summary>
    /// <returns>The name of the card.</returns>
    public string getCardName() {
        return cardName;
    }

    /// <summary>
    /// Gets the description of the card.
    /// </summary>
    /// <returns>The description of the card.</returns>
    public string getDescription() {
        return description;
    }

    /// <summary>
    /// Gets the prefab associated with the card.
    /// </summary>
    /// <returns>The card prefab.</returns>
    public GameObject getCardPrefab() {
        return cardPrefab;
    }

    /// <summary>
    /// Gets the sprite representing the card type.
    /// </summary>
    /// <returns>The card type sprite.</returns>
    public Sprite getCardType() {
        return cardType;
    }

    public Vector3 getCameraPosition() {
        return cameraPositon;
    }

    public Material getSkybox() {
        return skybox;
    }
}