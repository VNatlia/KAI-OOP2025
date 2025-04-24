#include <iostream>
#include "PolyUtils.h"

void processString(StringBase& obj) {
    std::cout << "Original Length: " << obj.getLength() << std::endl;
    std::cout << "Processed String: " << obj.removeChar() << std::endl;
}
