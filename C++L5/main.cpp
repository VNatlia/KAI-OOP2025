#include <iostream>
#include "Digits.h"
#include "Letters.h"
#include "PolyUtils.h"

int main() {
    Digits d("1234556789");
    Letters l("Alphabet with a and A");

    std::cout << "Digits" << std::endl;
    processString(d);

    std::cout << "\n Letters" << std::endl;
    processString(l);

    return 0;
}
