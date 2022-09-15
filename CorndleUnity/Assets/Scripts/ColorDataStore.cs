using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorDataStore : MonoBehaviour
{
    [SerializeField] Color wrongLetterColor;
    [SerializeField] Color letterInWordColor;
    [SerializeField] Color letterInRightPlaceColor;
    [SerializeField] Color lackOfLetterColor;

    static Color _wrongLetterColor;
    static Color _letterInWordColor;
    static Color _letterInRightPlaceColor;
    static Color _lackOfLetterColor;

    private void Awake()
    {
        _wrongLetterColor = wrongLetterColor;
        _letterInWordColor = letterInWordColor;
        _letterInRightPlaceColor = letterInRightPlaceColor;
        _lackOfLetterColor = lackOfLetterColor;
    }

    public static Color GetWrongLetterColor() { return _wrongLetterColor; }
    public static Color GetLetterInWordColor() { return _letterInWordColor; }
    public static Color GetLetterInRightPlaceColor() { return _letterInRightPlaceColor; }
    public static Color GetlackOfLetterColor() { return _lackOfLetterColor; }
}
