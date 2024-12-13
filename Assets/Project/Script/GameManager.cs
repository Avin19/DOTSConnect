using System.Collections.Generic;
using Connect.Comman;
using UnityEngine;


namespace Connect.Core
{
    public class GameManager : MonoBehaviour
    {
        #region  START_METHODS

        public static GameManager Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                Init();
                DontDestroyOnLoad(gameObject);
                return;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        private void Init()
        {

        }

        #endregion

        #region  LEVEL_DATA
        [SerializeField] private LevelData defaultLevel;
        [SerializeField] private LevelList allLevel;

        private Dictionary<string, LevelData> Levels;

        public LevelData GetLevel()
        {
            return defaultLevel; ;
        }

        #endregion

        #region  SCENE_LOAD

        private const string MainMenu = " MainMenu";
        private const string GamePlay = " GamePlay";


        public void GoToMainMenu()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(MainMenu);
        }

        public void GoToGamePlay()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(GamePlay);
        }

        #endregion
    }
}