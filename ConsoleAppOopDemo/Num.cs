namespace ConsoleAppOopDemo.Entities;
public class Num
{
    //fields
    private int _num01;
    public int Num01 { get => _num01; set => _num01 = value; }

    public int Num02 { get;set; }
    public int Number;

    public Num(int n)
    {
        Number = n;
    }
    public Num(int num01, int num02)
    {
        Num01 = num01;
        Num02 = num02;
    }


    public int Add() => Num01+Num02; //bodies-expression (lambda operator)
    public int Sub() => Num01-Num02;
    public int Mul() => Num01*Num02;

    public long Factorial()
    {
        if(Number == 0 || Number == 1) return Number; //dieu kien dung
        return Number-- * Factorial();
    }
}


