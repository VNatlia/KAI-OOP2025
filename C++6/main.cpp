#include <iostream>
#include "TextContainer.h"

int main() {
    TextContainer text;

    text.AddLine(MyString("   Hello    world!   "));
    text.AddLine(MyString("  This    is    C++  "));
    text.AddLine(MyString(" Clean     me up     "));

    std::cout << "Оригінальні рядки:\n";
    for (const auto& line : text.GetLines()) {
        std::cout << "[" << line.GetData() << "]\n";
    }

    text.CleanAll();

    std::cout << "\nПісля очищення:\n";
    for (const auto& line : text.GetLines()) {
        std::cout << "[" << line.GetData() << "]\n";
    }

    std::cout << "\nДовжина найкоротшого рядка: " << text.GetShortestLineLength() << "\n";
    std::cout << "Відсоток приголосних: " << text.GetConsonantPercentage() << "%\n";

    return 0;
}
