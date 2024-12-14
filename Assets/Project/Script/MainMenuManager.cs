using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public static MainMenuManager Instance;

    [SerializeField] private GameObject titlePanel;
    [SerializeField] private GameObject stagePanel;
    [SerializeField] private GameObject levelPanel;

    private void Awake()
    {
        Instance = this;
        titlePanel.SetActive(true);
        stagePanel.SetActive(false);
        levelPanel.SetActive(false);
    }

    public void ClickedPlay()
    {
        titlePanel.SetActive(false);
        stagePanel.SetActive(true);
    }

    public void ClickedBackToTitle()
    {
        titlePanel.SetActive(true);
        stagePanel.SetActive(false);
    }
    public void ClickedBackToStage()
    {
        stagePanel.SetActive(true);
        levelPanel.SetActive(false);
    }

    public UnityAction LevelOpened;

    [HideInInspector] public Color currentColor;

    [SerializeField] private TMP_Text levelTitleText;
    [SerializeField] private Image levelTitleImage;


    public void CLickedStage(string stageName, Color stageColor)
    {
        stagePanel.SetActive(false);
        levelPanel.SetActive(true);
        currentColor = stageColor;
        levelTitleText.text = stageName;
        levelTitleImage.color = currentColor;
        LevelOpened?.Invoke();
    }

}
