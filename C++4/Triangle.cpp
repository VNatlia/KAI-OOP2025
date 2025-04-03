#include "Triangle.h"
#include <cmath>

// ����������� �� �������������
Triangle::Triangle() : Figure() {}

// ����������� � ����������� (����� ������ ������������ �������� �����)
Triangle::Triangle(double ax1, double ay1, double ax2, double ay2, double ax3, double ay3)
    : Figure(ax1, ay1, ax2, ay2, ax3, ay3) {}

// ����������� ���������
Triangle::Triangle(const Triangle& other) : Figure(other) {}

// ����������
Triangle::~Triangle() {}

// ���������� ���������
double Triangle::perimeter() const {
    return sideLength(x1, y1, x2, y2) +
        sideLength(x2, y2, x3, y3) +
        sideLength(x3, y3, x1, y1);
}

// ���������� �����
double Triangle::area() const {
    double a = sideLength(x1, y1, x2, y2);
    double b = sideLength(x2, y2, x3, y3);
    double c = sideLength(x3, y3, x1, y1);
    double s = (a + b + c) / 2;
    return sqrt(s * (s - a) * (s - b) * (s - c));
}
