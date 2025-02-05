using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Connect.Core
{
    public class StageButton : MonoBehaviour
    {
        [SerializeField] private string stageName;
        [SerializeField] private Color stageColor;
        [SerializeField] private int stageNumber;
        [SerializeField] private Button button;
        [SerializeField] private TMP_Text text;


        private void Awake()
        {
            button.onClick.AddListener(OnButtonClick);
            text.text = stageName;

        }

        private void OnButtonClick()
        {
            GameManager.Instance.currentStage = stageNumber;
            GameManager.Instance.stageName = stageName;
            MainMenuManager.Instance.CLickedStage(stageName, stageColor);
        }
    }
}
