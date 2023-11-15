using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class SubSystemA
    {
        public void OperationA()
        {
            Console.WriteLine("SubSystem A");
        }
    }
    public class SubSystemB
    {
        public void OperationB()
        {
            Console.WriteLine("SubSystem B");
        }
    }
    public class SubSystemC
    {
        public void OperationC()
        {
            Console.WriteLine("SubSystem C");
        }
    }
    public class Facade
    {
        SubSystemA subSystemA = new SubSystemA();
        SubSystemB subSystemB = new SubSystemB();
        SubSystemC subSystemC = new SubSystemC();
        public void OperationAB()
        {
            subSystemA.OperationA();
            subSystemB.OperationB();
        }
        public void OperationBC()
        {
            subSystemB.OperationB();
            subSystemC.OperationC();
        }
    }
    //Паттерн Facade рекомендуется использовать, когда:
    // Требуется предоставить высокоуровневый интерфейс для замены множества низкоуровневых
    //интерфейсов.
    // Между клиентскими классами и классами подсистем имеется много зависимостей.
    // Требуется разложить систему на слои, при этом объект-фасад будет использоваться в качестве
    //точки входа в слой.

    //Назначение
    //Паттерн Facade - предоставляет унифицированный интерфейс(набор имен методов) вместо
    //интерфейса некоторой подсистемы(набора взаимосвязанных классов или объектов).
    //Класс Facade предоставляет высокоуровневый интерфейс(набор методов одного класса) вместо
    //низкоуровневого интерфейса подсистемы(наборов методов из разных классов входящих в состав
    //подсистемы).

    //Простым языком: 
    //Задача: скрыть сложную логику за простым фасадом
    //Собираем сложные структуры,объединяем и предоставляем простой способ манипуляции


}
