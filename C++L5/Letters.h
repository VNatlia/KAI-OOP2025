#pragma once
#include "StringBase.h"

class Letters : public StringBase {
public:
    Letters(std::string val) : StringBase(val) {}

    size_t getLength() const override;
    std::string removeChar() override;
};
