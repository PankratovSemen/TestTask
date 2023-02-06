using TestTaskLibrary1;

namespace TestTaskLibrary.Tests
{
    public class CalcAreaTests
    {
        [Fact]
        //Проверка на то является ли треугольник прямоугольным
        public void CheckRectangularTringle()
        {
            //Переменные треугольника
            int a = 3;
            int b = 4;
            int c = 5;
            //Создание экземпляра класса
            CalcArea calcArea = new();
            //Вызов функции для расчета площади треугольника
            calcArea.Object(a, b, c);
            //Проверка является ли треугольник прямоугольным
            Assert.True(calcArea.checkTringle);
        }

        [Fact]
        //Проверка расчета площади по радиусу круга
        public void CheckRadius()
        {
            //Создание экземпляра класс
            CalcArea calcArea = new();
            //Сравнение ожидаемого и фактического результатов
            Assert.Equal(12.5664, calcArea.Object(2));
        }
    }
}