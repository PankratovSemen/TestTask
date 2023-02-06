using TestTaskLibrary1;

namespace TestTaskLibrary.Tests
{
    public class CalcAreaTests
    {
        [Fact]
        //�������� �� �� �������� �� ����������� �������������
        public void CheckRectangularTringle()
        {
            //���������� ������������
            int a = 3;
            int b = 4;
            int c = 5;
            //�������� ���������� ������
            CalcArea calcArea = new();
            //����� ������� ��� ������� ������� ������������
            calcArea.Object(a, b, c);
            //�������� �������� �� ����������� �������������
            Assert.True(calcArea.checkTringle);
        }

        [Fact]
        //�������� ������� ������� �� ������� �����
        public void CheckRadius()
        {
            //�������� ���������� �����
            CalcArea calcArea = new();
            //��������� ���������� � ������������ �����������
            Assert.Equal(12.5664, calcArea.Object(2));
        }
    }
}