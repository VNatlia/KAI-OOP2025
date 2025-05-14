#ifndef EXPRESSION_H
#define EXPRESSION_H

#include <stdexcept>

class Expression {
private:
    double a, c, d;

public:
    Expression(double a, double c, double d);

    void setA(double value);
    void setC(double value);
    void setD(double value);

    double getA() const;
    double getC() const;
    double getD() const;

    double calculate() const;

private:
    double calculateLog(double x) const;
};

class InvalidArgumentException : public std::runtime_error {
public:
    InvalidArgumentException(const std::string& message)
        : std::runtime_error(message) {}
};

#endif
