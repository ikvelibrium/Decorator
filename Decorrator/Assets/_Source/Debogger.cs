using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debogger : MonoBehaviour
{
    [SerializeField] private HotDogSO classicHotDogSO;
    [SerializeField] private HotDogSO ceasarHotDogSO;
    [SerializeField] private HotDogSO extraMeatHotDogSO;
    [SerializeField] private HotDogSO cucumberDecoratorSO;
    [SerializeField] private HotDogSO onionDecoratorSO;

    private void Start()
    {
        ClassicHotDog firstHotDog = new ClassicHotDog(classicHotDogSO.Name, classicHotDogSO.Cost, classicHotDogSO.Weight);
        CucomberDecorator cucumbersInFirstHotDog =  new CucomberDecorator(cucumberDecoratorSO.Name, cucumberDecoratorSO.Cost, cucumberDecoratorSO.Weight, firstHotDog);
        OnionDecorator onionsInFirstHotDog = new OnionDecorator(onionDecoratorSO.Name, onionDecoratorSO.Cost, onionDecoratorSO.Weight, firstHotDog);

        CeasarHotDog secondHotDog = new CeasarHotDog(ceasarHotDogSO.Name, ceasarHotDogSO.Cost, ceasarHotDogSO.Weight);
        CucomberDecorator cucumbersInSecondHotDog = new CucomberDecorator(cucumberDecoratorSO.Name, cucumberDecoratorSO.Cost, cucumberDecoratorSO.Weight, secondHotDog);
        OnionDecorator onionsInSecondHotDog = new OnionDecorator(onionDecoratorSO.Name, onionDecoratorSO.Cost, onionDecoratorSO.Weight, secondHotDog);

        ExtraMeetHotDog thirdHotDog = new ExtraMeetHotDog(extraMeatHotDogSO.Name, extraMeatHotDogSO.Cost, extraMeatHotDogSO.Weight);
        CucomberDecorator cucumbersInThirdHotDog = new CucomberDecorator(cucumberDecoratorSO.Name, cucumberDecoratorSO.Cost, cucumberDecoratorSO.Weight, thirdHotDog);
        OnionDecorator onionsInThirdHotDog = new OnionDecorator(onionDecoratorSO.Name, onionDecoratorSO.Cost, onionDecoratorSO.Weight, thirdHotDog);

        Debug.Log($"{firstHotDog.Name} ({firstHotDog.GetWeight()}�) - {firstHotDog.GetCost()}�. " + $"\n�������������� ����������:" + $"\n{firstHotDog.Name} {cucumbersInFirstHotDog.Name} ({cucumbersInFirstHotDog.GetWeight()}�) - {cucumbersInFirstHotDog.GetCost()}�." + $"\n{firstHotDog.Name} {onionsInFirstHotDog.Name} ({onionsInFirstHotDog.GetWeight()}�) - {onionsInFirstHotDog.GetCost()}�.");
        Debug.Log($"{secondHotDog.Name} ({secondHotDog.GetWeight()}�) - {secondHotDog.GetCost()}�. " + $"\n�������������� ����������:" + $"\n{secondHotDog.Name} {cucumbersInSecondHotDog.Name} ({cucumbersInSecondHotDog.GetWeight()}�) - {cucumbersInSecondHotDog.GetCost()}�." + $"\n{secondHotDog.Name} {onionsInSecondHotDog.Name} ({onionsInSecondHotDog.GetWeight()}�) - {onionsInSecondHotDog.GetCost()}�.");
        Debug.Log($"{thirdHotDog.Name} ({thirdHotDog.GetWeight()}�) - {thirdHotDog.GetCost()}�. " + $"\n�������������� ����������:" + $"\n{thirdHotDog.Name} {cucumbersInThirdHotDog.Name} ({cucumbersInThirdHotDog.GetWeight()}�) - {cucumbersInThirdHotDog.GetCost()}�." + $"\n{thirdHotDog.Name} {onionsInThirdHotDog.Name} ({onionsInThirdHotDog.GetWeight()}�) - {onionsInThirdHotDog.GetCost()}�.");
    }
}
