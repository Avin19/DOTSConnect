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
            currentStage = 1;
            currentLevel = 1;

            Levels = new Dictionary<string, LevelData>();

            foreach (var level in allLevel.Levels)
            {
                Levels[level.levelName] = level;
            }
        }

        #endregion

        #region GAME_VARIABLES


        [HideInInspector]
        public int currentStage;
        [HideInInspector]
        public int currentLevel;
        [HideInInspector]
        public string stageName;

        public bool IsLevelUnlocked(int level)
        {
            string levelName = "Level" + currentStage.ToString() + level.ToString();

            if (level == 1)
            {
                PlayerPrefs.SetInt(levelName, 1);
                return true;
            }
            if (PlayerPrefs.HasKey(levelName))
            {
                return PlayerPrefs.GetInt(levelName) == 1;
            }
            PlayerPrefs.SetInt(levelName, 0);
            return false;
        }

        public void UnlockLevel()
        {
            currentLevel++;

            if (currentLevel == 51)
            {
                currentLevel = 1;
                currentStage++;

                if (currentStage == 8)
                {
                    currentStage = 1;
                    GoToMainMenu();
                }
            }
            string levelName = "Level" + currentStage.ToString() + currentLevel.ToString();
            PlayerPrefs.SetInt(levelName, 1);
        }

        #endregion

        #region  LEVEL_DATA
        [SerializeField] private LevelData defaultLevel;
        [SerializeField] private LevelList allLevel;

        private Dictionary<string, LevelData> Levels;

        public LevelData GetLevel()
        {
            string levelName = "Level" + currentStage.ToString() + currentLevel.ToString();

            if (Levels.ContainsKey(levelName))
            {
                return Levels[levelName];
            }

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