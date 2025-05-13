
#include <vector>
#include "MyString.h"

// Клас-контейнер "Текст", який складається з рядків
class TextContainer {
private:
    std::vector<MyString> lines;

public:
    void AddLine(const MyString& line);
    void RemoveLine(size_t index);
    void ClearAll();
    void CleanAll();

    size_t GetShortestLineLength() const;
    double GetConsonantPercentage() const;
    const std::vector<MyString>& GetLines() const;
};
