#ifndef TRIANGLE_H
#define TRIANGLE_H

#include "Figure.h"

class Triangle : public Figure {
public:
    // Конструктори
    Triangle();
    Triangle(double, double, double, double, double, double);
    Triangle(const Triangle& other);
  

    // Деструктор
    ~Triangle();

    // Методи
    double perimeter() const;
    double area() const;
};

#endif

