using UnityEngine;
using UnityEngine.TextCore.Text;

[CreateAssetMenu(menuName = "CreateCharacter", fileName = "Character")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public Sprite characterSprite;
}
