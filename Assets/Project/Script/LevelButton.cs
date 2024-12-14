using System;
using Connect.Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace Connect.Core

{
    public class LevelButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private Image image;
        [SerializeField] private TMP_Text levelText;
        [SerializeField] private Color inactiveColor;

        private bool isLevelUnlocked;
        private int currentLevel;

        private void Awake()
        {
            button.onClick.AddListener(OnLevelUnlocked);
        }

        private void OnLevelUnlocked()
        {
            if (!isLevelUnlocked)
                return;

            GameManager.Instance.currentLevel = currentLevel;
            GameManager.Instance.GoToGamePlay();
        }

        private void OnEnable()
        {

        }
        private void OnDisable()
        {

        }
    }
}