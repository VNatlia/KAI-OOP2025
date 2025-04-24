
#include "Digits.h"

size_t Digits::getLength() const {
    return value.length();
}

std::string Digits::removeChar() {
    std::string result;
    for (char ch : value) {
        if (ch != '5') result += ch;
    }
    return result;
}
