#ifndef TRIANGLE_H
#define TRIANGLE_H

#include "Figure.h"

class Triangle : public Figure {
public:
    Triangle();
    Triangle(double, double, double, double, double, double);
    Triangle(const Triangle& other);
  
    ~Triangle();

    double perimeter() const;
    double area() const;
};

#endif

