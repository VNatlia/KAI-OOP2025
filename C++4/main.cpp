#include <iostream>
#include "Triangle.h"

int main() {
    Triangle t(0, 0, 3, 0, 3, 4);
    std::cout << "permeter: " << t.perimeter() << "\n";
    std::cout << "area: " << t.area() << "\n";
    return 0;
}
