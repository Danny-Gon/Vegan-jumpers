using Configurations;
using UnityEngine;
using UnityEngine.TextCore.Text;


namespace Instantiate
{
    public class CharacterFactory
    {
        private readonly PlayerConfiguration _config;

        public CharacterFactory(PlayerConfiguration config)
        {
            _config = config;
        }

        public PlayerController Create(CharacterData id)
        {
            PlayerController instantiateCharacter = _config.findCharacter(id);
            return UnityEngine.Object.Instantiate(instantiateCharacter);

        }

    }
}
