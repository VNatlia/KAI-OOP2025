
#pragma once
#include <string>

class StringBase {
protected:
    std::string value;

public:
    StringBase(std::string val) : value(val) {}
    virtual ~StringBase() {}

    std::string getValue() const { return value; }

    virtual size_t getLength() const = 0;
    virtual std::string removeChar() = 0;
};
