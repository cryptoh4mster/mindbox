using System;
using Xunit;
using Figures.Exceptions;
using Figures;

namespace FiguresTests
{
    
    public class FiguresTests
    {
        /// <summary>
        /// �������� ���������� ��� ������������� ������� �����
        /// </summary>
        [Fact]
        public void CheckIncorrectCircleRadiusException()
        {
            Assert.Throws<IncorrectValueException>(()=> { new Circle(-5); });
        }

        /// <summary>
        /// �������� ���������� ��� ������������� ������� ������������
        /// </summary>
        [Fact]
        public void CheckIncorrectTriangleValuesException()
        {
            Assert.Throws<IncorrectValueException>(() => { new Triangle(1, -2, 3); });
        }

        /// <summary>
        /// �������� ������������ ���������� ������� �����
        /// </summary>
        [Fact]
        public void CheckCorrectCircleAreaValue()
        {
            Assert.Equal(38.4845, Math.Round(new Circle(3.5).GetArea(), 4));
        }

        /// <summary>
        /// �������� ������������ ���������� ������� ������������
        /// </summary>
        [Fact]
        public void CheckCorrectTriangleAreaValue()
        {
            Assert.Equal(6, new Triangle(3, 4, 5).GetArea());
        }

        /// <summary>
        /// �������� ������������ ����������� ��������������� ������������, ��������� true
        /// </summary>
        [Fact]
        public void CheckCorrectIsRightTriangle()
        {
            Assert.True(new Triangle(3, 4, 5).IsRightTriangle());
        }

        /// <summary>
        /// �������� ������������ ����������� ��������������� ������������, ��������� false
        /// </summary>
        [Fact]
        public void CheckIncorrectIsRightTriangle()
        {
            Assert.False(new Triangle(5, 5, 5).IsRightTriangle());
        }

        /// <summary>
        /// �������� ������������ ���������� ������� ����� ��� ������������
        /// </summary>
        [Fact]
        public void CheckCorrectShapeCircleAreaValue()
        {
            Shape circle = new Circle(3.5);
            Assert.Equal(38.4845, Math.Round(circle.GetArea(), 4));
        }

        /// <summary>
        /// �������� ������������ ���������� ������� ������������ ��� ������������
        /// </summary>
        [Fact]
        public void CheckCorrectShapeTriangleAreaValue()
        {
            Shape triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.GetArea());
        }

        /// <summary>
        /// �������� ���������� ��� �������������� � ���������� ��������� ������������
        /// </summary>
        [Fact]
        public void CheckIncorrectTriangleSidesValues()
        {
            Assert.Throws<IncorrectTriangleSidesValuesException>(() => { new Triangle(3, 4, 7); });
        }

    }
}
