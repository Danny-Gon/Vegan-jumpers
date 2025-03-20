using Configurations;
using Instantiate;
using UnityEngine;

    public class GameInstaller : MonoBehaviour
    {
        [Header("Requeriments")]
        public Transform positionPlayer1;
        //public Transform positionPlayer2;

        [Header("Factory configuration")]
        public PlayerConfiguration configuration;

        private CharacterFactory _characterFactory;

        private void Awake()
        {
            _characterFactory = new CharacterFactory(configuration);
        }

        private void Start()
        {
            SpawnPlayer();
        }

        private void SpawnPlayer()
        {
            PlayerController player1 = _characterFactory.Create(configuration.playerSelected);
            player1.transform.position = positionPlayer1.position;
        }
    }


