namespace TestTaskLibrary1
{
    public class CalcArea
    {
        public bool checkTringle { get; private set; }

        //Метод для расчета площади курга по радиусу.
        public double Object(int Radius)
        {
            //Значение ПИ
            double pi = Math.PI;
            //Расчет площади круга по радиусу
            double S = pi*Math.Pow(Radius,2);
            return Math.Round(S, 4);
        }

        //Метод перегрузки для расчета площади прямоугольного тругольника
        public double Object(int a, int b, int c)
        {
            bool rectangular()
            {
                bool result;
                //Значение c для проверки является ли треугольник прямоугольным по теореме Пифагора.
                double TrueResult = Math.Pow(c, 2);
                //Значение, которое нужно проверить на то что является ли треугольник прямоугольным
                double check = Math.Pow(a, 2) + Math.Pow(b, 2);
                //Проверка значений
                if (check == TrueResult)
                {

                    
                    checkTringle = true;
                    //Вернуть true елси треугольник прямоугольный
                    return true;
                }
                else
                {
                    checkTringle = false;
                    //Вернуть false елси треугольник не является прямоугольным
                    return false;
                }
            }
            rectangular();
            //Проверка является треугольник прямоугольным.
           
            //Расчет полупериметра треугольника 
            double p = (a + b + c) / 2;
            //Расчет площади треугольника по формуле Герона
            double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return s;
        }

        
    }
}