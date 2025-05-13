#include "TextContainer.h"

// Додати рядок
void TextContainer::AddLine(const MyString& line) {
    lines.push_back(line);
}

// Видалити рядок за індексом
void TextContainer::RemoveLine(size_t index) {
    if (index < lines.size()) {
        lines.erase(lines.begin() + index);
    }
}

// Очистити всі рядки
void TextContainer::ClearAll() {
    lines.clear();
}

// Очистити пробіли в усіх рядках
void TextContainer::CleanAll() {
    for (auto& line : lines) {
        line.CleanSpaces();
    }
}

// Отримати найменшу довжину рядка
size_t TextContainer::GetShortestLineLength() const {
    if (lines.empty()) return 0;

    size_t minLen = lines[0].GetLength();
    for (const auto& line : lines) {
        if (line.GetLength() < minLen) {
            minLen = line.GetLength();
        }
    }
    return minLen;
}

// Отримати % приголосних у всьому тексті
double TextContainer::GetConsonantPercentage() const {
    int totalChars = 0;
    int consonants = 0;

    for (const auto& line : lines) {
        totalChars += static_cast<int>(line.GetLength());
        consonants += line.CountConsonants();
    }

    if (totalChars == 0) return 0.0;
    return (static_cast<double>(consonants) / totalChars) * 100.0;
}

// Повернути всі рядки
const std::vector<MyString>& TextContainer::GetLines() const {
    return lines;
}
