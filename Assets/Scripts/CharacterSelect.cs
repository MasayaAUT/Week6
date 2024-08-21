using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterSelect : MonoBehaviour
{
    //This is in our project folder
    [Header("In Project Folder")]
    public Character currentCharacter; //reference to the scriptable object in our project folder

    //These are in the scene
    [Header("In the hierarchy - DONT FORGET TO ADD!!!!")]
    public Image characterImage; //reference to the image in the editor
    public TextMeshProUGUI characterNameText; //reference to the text for the name
    public TextMeshProUGUI characterDescriptionText; //reference to the text for the description

    // Start is called before the first frame update
    void Start()
    {
        UpdateCharacter();
    }

    public void UpdateCharacter()
    {
        characterImage.sprite = currentCharacter.characterSprite; //Sets the sprite
        characterNameText.text = currentCharacter.characterName; //Sets the name
        characterDescriptionText.text = currentCharacter.characterDescription; //Sets the description
    }
}
