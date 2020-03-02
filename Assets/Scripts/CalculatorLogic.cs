
using System;
using System.Collections.Generic;

public class Calculator 
{
    private float _operand;
    private static float _memory = 0;
    private string _lastChooseOperation = "";
    private static System.Collections.Generic.Dictionary<string, System.Action<float>> _operations = new System.Collections.Generic.Dictionary<string, System.Action<float>>
{
{"+",  M_Sum},
{"-",  M_Subtraction},
{"*",  M_Multiplication},
{"/",  M_Division}
};



    public void set_operand(float inputValue)
    {
        this._operand = inputValue;
    }

    public void Clear_All()
    {
        _operand = 0;
        _memory = 0;
        _lastChooseOperation = "";
    }

    public float Memory => _memory;

    public Dictionary<string, Action<float>> Operations
    {
        get
        {
            return _operations;
        }

        set
        {
            _operations = value;
        }
    }

    private static void M_Multiplication(float b)
    {
        _memory *= b;
    }

    private static void M_Division(float b)
    {
        _memory /= b;
    }

    private static void M_Sum(float b)
    {
        _memory += b;
    }

    private static void M_Subtraction(float b)
    {
        _memory -= b;
    }

    public void MakeOperation(string Operation)
    {
        if (_lastChooseOperation == "")
        {
            _lastChooseOperation = Operation;
            _memory = _operand;
        }
        else if (_lastChooseOperation == "=")
        {
            MakeLastOperation();
        }
        else
        {
            MakeLastOperation();
            _lastChooseOperation = Operation;
        }
    }

    private void MakeLastOperation()
    {
        System.Action<float> operation = _operations[_lastChooseOperation];
        operation(_operand);
    }
}
