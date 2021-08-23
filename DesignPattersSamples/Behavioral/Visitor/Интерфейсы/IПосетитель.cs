using DesignPattersSamples.Behavioral.Visitor.Модели.Объекты;

// ReSharper disable UnusedParameter.Global
namespace DesignPattersSamples.Behavioral.Visitor.Интерфейсы
{
    public interface IПосетитель
    {
        void ПроверитьСтроителя(Строитель строитель);
        void ПроверитьОборудование(Оборудование оборудование);
    }
}