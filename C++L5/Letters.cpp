#include "Letters.h"

size_t Letters::getLength() const {
    return value.length();
}

std::string Letters::removeChar() {
    std::string result;
    for (char ch : value) {
        if (ch != 'a' && ch != 'A') result += ch;
    }
    return result;
}
