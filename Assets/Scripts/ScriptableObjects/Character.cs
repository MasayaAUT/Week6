using UnityEngine;

//Add this to create the scriptable object
[CreateAssetMenu(menuName = "Characters", fileName = "New Character")]
public class Character : ScriptableObject
{
    //What data do we need???????
    public string characterName; //string for a name
    public Sprite characterSprite; //sprite for their image

    [TextArea]
    public string characterDescription; //string for their description

}

