using Configurations;
using Photon.Pun;
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
            GameObject target = _config.findCharacter(id).gameObject;
            return PhotonNetwork.Instantiate(target.name, Vector3.zero, target.transform.rotation).GetComponent<PlayerController>();
        }
    }
}
