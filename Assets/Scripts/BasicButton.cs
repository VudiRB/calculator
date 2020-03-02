using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))] 
public class BasicButton : MonoBehaviour 
{
    private Button _textButton;
    public string value = "None";
    public Text textComponent;

    protected void ClearTextOnScrean()
    {
        textComponent.text = "0";
    }

    private void Awake() 
    {
        _textButton = GetComponent<Button>(); 
        _textButton.GetComponentInChildren<Text>().text = value; 
    }
}
