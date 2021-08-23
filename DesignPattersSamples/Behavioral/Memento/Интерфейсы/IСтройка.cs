namespace DesignPattersSamples.Behavioral.Memento.Интерфейсы
{
    public interface IСтройка
    {
        void ЗавезтиМатериал(int мешковЦемента, int мешковКлея, int пачекПлитки);
        void ПроводитьРаботы();
        public IСнимокСтройки ЗапомнитьСостояние();
        public void ВосстановитьСостояние(IСнимокСтройки снимок);
    }
}