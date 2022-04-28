using System;
using Xunit;
using Figures.Exceptions;
using Figures;

namespace FiguresTests
{
    
    public class FiguresTests
    {
        #region ������������ �����
        /// <summary>
        /// �������� ���������� ��� ������������� ������� �����
        /// </summary>
        [Fact]
        public void Add_NegativeCircleRadius_ReturnsIncorrectValueException() 
        {
            //Assert
            Assert.Throws<IncorrectValueException>(()=> { new Circle(-5); });
        }

        /// <summary>
        /// �������� ������������ ���������� ������� �����
        /// </summary>
        [Fact]
        public void IsEqual_CircleRadius_ReturnsCircleArea()
        {
            //Arrange
            Circle circle = new Circle(3.5);
            
            //Act
            var circleArea = Math.Round(circle.GetArea(), 4);

            //Assert
            Assert.Equal(38.4845, circleArea);
        }

        /// <summary>
        /// �������� ������������ ���������� ������� ����� ��� ������������
        /// </summary>
        [Fact]
        public void IsEqual_ShapeCircleRadius_ReturnsCircleArea()
        {
            //Arrange
            Shape circle = new Circle(3.5);

            //Act
            var circleArea = Math.Round(circle.GetArea(), 4);

            //Assert
            Assert.Equal(38.4845, circleArea);
        }
        #endregion

        #region ������������ ������������
        /// <summary>
        /// �������� ���������� ��� ������������� ������� ������������
        /// </summary>
        [Fact]
        public void Add_NegativeTriangleSide_ReturnsIncorrectValueException()
        {
            //Assert
            Assert.Throws<IncorrectValueException>(() => { new Triangle(1, -2, 3); });
        }

        /// <summary>
        /// �������� ���������� ��� �������������� � ���������� ��������� ������������
        /// </summary>
        [Fact]
        public void Add_NotExistingTriangleSides_ReturnsIncorrectTriangleSidesValuesException()
        {
            //Assert
            Assert.Throws<IncorrectTriangleSidesValuesException>(() => { new Triangle(3, 4, 7); });
        }

        /// <summary>
        /// �������� ������������ ���������� ������� ������������
        /// </summary>
        [Fact]
        public void IsEqual_TriangleSides_ReturnsTriangleArea()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //Act
            var triangleArea = triangle.GetArea();

            //Assert
            Assert.Equal(6, triangleArea);
        }

        /// <summary>
        /// �������� ������������ ����������� ��������������� ������������, ��������� true
        /// </summary>
        [Fact]
        public void IsRightTriangle_TriangleSides_ShouldBeTrue()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //Act
            bool isRightTriangle = triangle.IsRightTriangle();

            //Assert
            Assert.True(isRightTriangle);
        }

        /// <summary>
        /// �������� ������������ ����������� ��������������� ������������, ��������� false
        /// </summary>
        [Fact]
        public void IsRightTriangle_TriangleSides_ShouldBeFalse()
        {
            //Arrange
            Triangle triangle = new Triangle(5, 5, 5);

            //Act
            bool isRightTriangle = triangle.IsRightTriangle();

            //Assert
            Assert.False(isRightTriangle);
        }

        /// <summary>
        /// �������� ������������ ���������� ������� ������������ ��� ������������
        /// </summary>
        [Fact]
        public void IsEqual_ShapeTriangleSides_ReturnsTriangleArea()
        {
            //Arrange
            Shape triangle = new Triangle(3, 4, 5);

            //Act
            var triangleArea = triangle.GetArea();

            //Assert
            Assert.Equal(6, triangleArea);
        }
        #endregion  
    }
}
