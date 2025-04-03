#include <iostream>
#include "Triangle.h"

int main() {
    Triangle t(0, 0, 3, 0, 3, 4);
    std::cout << "Периметр: " << t.perimeter() << "\n";
    std::cout << "Площа: " << t.area() << "\n";
    return 0;
}
