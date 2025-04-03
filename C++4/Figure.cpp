#include "Figure.h"
#include <cmath>


Figure::Figure() : x1(0), y1(0), x2(0), y2(0), x3(0), y3(0) {}


Figure::Figure(double ax1, double ay1, double ax2, double ay2, double ax3, double ay3)
    : x1(ax1), y1(ay1), x2(ax2), y2(ay2), x3(ax3), y3(ay3) {}


Figure::Figure(const Figure& other)
    : x1(other.x1), y1(other.y1), x2(other.x2), y2(other.y2), x3(other.x3), y3(other.y3) {}



Figure::~Figure() {}


double Figure::sideLength(double x1, double y1, double x2, double y2) const {
    return sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
}
