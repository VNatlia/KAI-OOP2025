#pragma once
#include <string>
#include "ICleanable.h"

// Клас "Рядок" з методами обробки тексту
class MyString : public ICleanable {
private:
    std::string data;

public:
    MyString(const std::string& str = "");

    std::string GetData() const;
    size_t GetLength() const;
    int CountConsonants() const;

    void CleanSpaces() override;
};
