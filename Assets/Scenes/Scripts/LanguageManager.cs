using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Text hairText;
    public Text shirtText;
    public Text pantsText;
    public Text shoesText;

    public LanguageTexts spanishTexts;
    public LanguageTexts englishTexts;
    public LanguageTexts italianTexts;

    public void SetLanguageToSpanish() => SetLanguage(spanishTexts);
    public void SetLanguageToEnglish() => SetLanguage(englishTexts);
    public void SetLanguageToItalian() => SetLanguage(italianTexts);

    private void SetLanguage(LanguageTexts language)
    {
        hairText.text = language.hair;
        shirtText.text = language.shirt;
        pantsText.text = language.pants;
        shoesText.text = language.shoes;
    }
}
