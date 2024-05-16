using UnityEngine;
using UnityEngine.UI;

public class TextBoxColorChanger : MonoBehaviour
{
    public InputField textBox; // Referenz auf die Textbox
    public Text coloredText; // Referenz auf den Text, der die eingefärbte Version des Textes anzeigt

    // Farben für verschiedene Textinhalte
    private Color defaultColor = Color.white;
    private Color godzillaColor = Color.red;

    void Start()
    {
        // Standardfarbe zuweisen
        coloredText.color = defaultColor;

        // Event hinzufügen, das bei Änderungen im Textfeld aufgerufen wird
        textBox.onValueChanged.AddListener(OnTextBoxValueChanged);
    }

    // Diese Methode wird aufgerufen, wenn sich der Text im Textfeld ändert
    void OnTextBoxValueChanged(string newText)
    {
        // Überprüfen Sie den Text und ändern Sie die Farbe entsprechend
        if (newText.Contains("Godzilla"))
        {
            coloredText.color = godzillaColor;
        }
        else
        {
            coloredText.color = defaultColor;
        }

        // Den eingefärbten Text aktualisieren
        coloredText.text = newText;
    }
}