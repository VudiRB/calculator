using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationButton : BasicButton
{

    private static Calculator _objectOfCalculator = new Calculator();//initialization of singleton

    private void GetValue() //passing a value to an instance of the calculator class
    {   
        try
        {
            _objectOfCalculator.set_operand(System.Convert.ToSingle(textComponent.text));
        }
        catch (System.SystemException)
        {
            Debug.Log("Error converting or transferring a value: " + textComponent.text);
        }
    }

    public void PressAC() //Action for clicking on AC button
    {
        ClearTextOnScrean();
        _objectOfCalculator.Clear_All();
    }

    public void PressOperator() //Action for clicking on operation button (+,-,*,/)
    {
        GetValue();
        ClearTextOnScrean();
        try
        {
            _objectOfCalculator.MakeOperation(value);
        }
        catch (System.SystemException)
        {
            Debug.Log("Error of the operation:" + value);
        }

    }

    public void PressEqual() //Action for clicking on "Equal"
    {
        GetValue();
        try
        {
            _objectOfCalculator.MakeOperation(value);
        }
        catch (System.SystemException)
        {
            Debug.Log("Error of the operation:" + value);
        }

        try
        {
            textComponent.text = System.Convert.ToString(_objectOfCalculator.Memory);
        }
        catch (System.SystemException)
        {
            Debug.Log("Error converting or transferring a value: " + _objectOfCalculator.Memory);
        }

        _objectOfCalculator.Clear_All();
    }
}
