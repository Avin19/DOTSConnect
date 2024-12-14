
using Connect.Core;
using UnityEngine;
using UnityEngine.UI;

public class StageButton : MonoBehaviour
{
    [SerializeField] private string stageName;
    [SerializeField] private Color stageColor;
    [SerializeField] private int stageNumber;
    [SerializeField] private Button button;


    private void Awake()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        GameManager.Instance.currentStage = stageNumber;
        GameManager.Instance.stageName = stageName;
        MainMenuManager.Instance.CLickedStage(stageName, stageColor);
    }
}
