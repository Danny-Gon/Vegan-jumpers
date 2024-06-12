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

        public GameObject Create(int playerNumber)
        {
            GameObject instantiateCharacter = _config.playerSelections[playerNumber].characterPrefab;
            return UnityEngine.Object.Instantiate(instantiateCharacter);

        }

    }
}
