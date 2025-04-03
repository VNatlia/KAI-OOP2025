#ifndef FIGURE_H
#define FIGURE_H

class Figure {
protected:
    double x1, y1, x2, y2, x3, y3;

public:
    // Конструктори
    Figure();
    Figure(double, double, double, double, double, double);
    Figure(const Figure& other);
  

    // Деструктор
    virtual ~Figure();

    // Метод для обчислення довжини сторони
    double sideLength(double, double, double, double) const;
};

#endif
