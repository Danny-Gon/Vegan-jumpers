using System.Collections.Generic;
using UnityEngine;

namespace Configurations
{
    [CreateAssetMenu(fileName = "Configuration/Player", menuName = "PlayerConfiguration")]
    public class PlayerConfiguration : ScriptableObject
    {
        public List<PlayerController> characters;
        public CharacterData playerSelected;

        public PlayerController findCharacter(CharacterData id)
        {
            return characters.Find(x => x.id == id);
        }
    }
}
