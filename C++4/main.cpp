#include <iostream>
#include "Triangle.h"

int main() {
    Triangle t(0, 0, 3, 0, 3, 4);
    std::cout << "��������: " << t.perimeter() << "\n";
    std::cout << "�����: " << t.area() << "\n";
    return 0;
}
