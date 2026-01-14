using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdater : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;

    public void UpdateText(int points)
    {
        _pointsText.text = points.ToString();
    }
}
