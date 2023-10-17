using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnionDecorator : HotdogDecorator
{
    // �����������
    public OnionDecorator(string name, int cost, int weight, AHotDog hotdog) : base(name, cost, weight, hotdog)
    {

    }

    public override int GetCost() => HotDog.GetCost() + Cost;
    public override int GetWeight() => HotDog.GetWeight() + Cost;
}
