using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public class NumberButton : BasicButton
{
    private string _text;
    public void AddValueToText()
    {
        if (textComponent.text.Length < 10)
        {
            _text = textComponent.text;
            _text += value;
            try
            {
                textComponent.text = System.Convert.ToString(System.Convert.ToSingle(_text));
            }
            catch (System.SystemException)
            {
                Debug.Log("Error in adding a value");
            }
        }
    }

    public void AddPoint()
    {
        if (textComponent.text.Length < 8)
        {
            textComponent.text += value;
        }
    }

    public void DeleteLastSymbol()
    {
        if (textComponent.text.Length > 0)
            textComponent.text = textComponent.text.Remove(textComponent.text.Length - 1);
    }
}
