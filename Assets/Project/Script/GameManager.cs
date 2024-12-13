using UnityEngine;


namespace Connect.Core
{
    public class GameManager : MonoBehaviour
    {
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