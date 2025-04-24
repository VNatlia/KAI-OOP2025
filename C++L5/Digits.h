#pragma once
#include "StringBase.h"

class Digits : public StringBase {
public:
    Digits(std::string val) : StringBase(val) {}

    size_t getLength() const override;
    std::string removeChar() override;
};
