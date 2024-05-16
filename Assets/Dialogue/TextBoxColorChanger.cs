using UnityEngine;
using UnityEngine.UI;

public class TextBoxColorChanger : MonoBehaviour
{
    public InputField textBox; // Referenz auf die Textbox
    public Text coloredText; // Referenz auf den Text, der die eingef�rbte Version des Textes anzeigt

    // Farben f�r verschiedene Textinhalte
    private Color defaultColor = Color.white;
    private Color godzillaColor = Color.red;

    void Start()
    {
        // Standardfarbe zuweisen
        coloredText.color = defaultColor;

        // Event hinzuf�gen, das bei �nderungen im Textfeld aufgerufen wird
        textBox.onValueChanged.AddListener(OnTextBoxValueChanged);
    }

    // Diese Methode wird aufgerufen, wenn sich der Text im Textfeld �ndert
    void OnTextBoxValueChanged(string newText)
    {
        // �berpr�fen Sie den Text und �ndern Sie die Farbe entsprechend
        if (newText.Contains("Godzilla"))
        {
            coloredText.color = godzillaColor;
        }
        else
        {
            coloredText.color = defaultColor;
        }

        // Den eingef�rbten Text aktualisieren
        coloredText.text = newText;
    }
}