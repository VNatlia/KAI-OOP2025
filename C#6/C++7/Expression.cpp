#include "Expression.h"
#include <cmath>

Expression::Expression(double a, double c, double d) : a(a), c(c), d(d) {}

void Expression::setA(double value) { a = value; }
void Expression::setC(double value) { c = value; }
void Expression::setD(double value) { d = value; }

double Expression::getA() const { return a; }
double Expression::getC() const { return c; }
double Expression::getD() const { return d; }

double Expression::calculateLog(double x) const {
    if (x <= 0)
        throw InvalidArgumentException("Logarithm of non-positive number.");
    return log10(x);
}

double Expression::calculate() const {
    double denominator = a * a - 1;
    if (denominator == 0)
        throw InvalidArgumentException("Division by zero.");
    double logPart = calculateLog(d / 4.0);
    return (2 * c - logPart) / denominator;
}
