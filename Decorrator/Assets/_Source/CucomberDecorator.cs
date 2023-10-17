using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CucomberDecorator : HotdogDecorator
{
    // конструктор
    public CucomberDecorator(string name, int cost, int weight, AHotDog hotdog) : base(name, cost, weight, hotdog)
    {

    }

    public override int GetCost() => HotDog.GetCost() + Cost;
    public override int GetWeight() => HotDog.GetWeight() + Weight;
}
