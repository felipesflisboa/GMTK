﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// General game HUD
/// </summary>
public class HUD : MonoBehaviour {
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI timeText;

    void Start() {
        levelText.text = GameManager.modeData is MarathonData ? $"Level {(GameManager.modeData as MarathonData).level}" : string.Empty;
    }

    void Update() {
        timeText.text = $"{GameManager.I.CurrentTime.ToString("00.000")} s";
    }
}
