using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AHotDog
{
    public string Name { get; protected set; }
    public int Cost { get; protected set; }
    public int Weight { get; protected set; }

    // конструктор
    public AHotDog(string _name, int _cost, int _weight)
    {
        Name = _name;
        Cost = _cost;
        Weight = _weight;
    }

    public string GetName() => Name;
    public virtual int GetCost() => Cost;
    public virtual int GetWeight() => Weight;
}
