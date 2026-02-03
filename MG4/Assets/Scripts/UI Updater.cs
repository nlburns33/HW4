using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIUpdater : MonoBehaviour
{
    [SerializeField] TMP_Text _pointsText;
    // Start is called before the first frame update
    void Start()
    {
        Locator.Instance.Player.PointsChanged += UpdatePoints;
    }

    // Update is called once per frame
    void UpdatePoints(int points)
    {
        //update UI text
        _pointsText.text = "Score: " + points;
    }
}
