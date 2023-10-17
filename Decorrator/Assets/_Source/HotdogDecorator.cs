using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HotdogDecorator : AHotDog
{
    public AHotDog HotDog { get; protected set; }

    // �����������
    public HotdogDecorator(string name, int cost, int weight, AHotDog hotdog) : base(name, cost, weight)
    {
        HotDog = hotdog;
    }

    public override int GetCost() => HotDog.GetCost();
    public override int GetWeight() => HotDog.GetWeight();
}
