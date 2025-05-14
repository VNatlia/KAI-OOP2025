#include <iostream>
#include "Expression.h"

int main() {
    Expression arr[] = {
        Expression(2, 3, 8),
        Expression(1, 4, -2), // логарифм < 0
        Expression(1, 3, 4)   // знаменник = 0
    };

    for (int i = 0; i < 3; ++i) {
        try {
            std::cout << "Result " << i + 1 << ": " << arr[i].calculate() << std::endl;
        }
        catch (const InvalidArgumentException& e) {
            std::cerr << "Error in object " << i + 1 << ": " << e.what() << std::endl;
        }
    }

    return 0;
}
