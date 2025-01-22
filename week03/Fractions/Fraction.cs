using System;

public class Fraction
{
    private int _numerador;
    private int _denominador;

    public Fraction()
    {
        _numerador = 1;
        _denominador = 1;
    }

    public Fraction(int numerador)
    {
        _numerador = numerador;
        _denominador = 1;
    }

    public Fraction(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador != 0 ? denominador : throw new ArgumentException("Denominator cannot be zero.");
    }

    public int GetNumerador()
    {
        return _numerador;
    }

    public void SetNumerador(int numerador)
    {
        _numerador = numerador;
    }

    public int GetDenominator()
    {
        return _denominador;
    }

    public void SetDenominador(int denominador)
    {
        if (denominador != 0)
        {
            _denominador = denominador;
        }
        else
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    public string GetFractionString()
    {
        return $"{_numerador}/{_denominador}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerador / _denominador;
    }
}
