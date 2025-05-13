#include "MyString.h"
#include <cctype>
#include <sstream>

// �����������
MyString::MyString(const std::string& str) : data(str) {}

// �������� �����
std::string MyString::GetData() const {
    return data;
}

// �������� ������� �����
size_t MyString::GetLength() const {
    return data.length();
}

// ���������� ������� �����������
int MyString::CountConsonants() const {
    int count = 0;
    for (char ch : data) {
        ch = static_cast<char>(tolower(ch));
        if (isalpha(ch) && !(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')) {
            count++;
        }
    }
    return count;
}

// �������� ������: �������, �����, � ������ ������ ��������
void MyString::CleanSpaces() {
    size_t start = data.find_first_not_of(" \t");
    size_t end = data.find_last_not_of(" \t");

    if (start == std::string::npos) {
        data.clear();
        return;
    }

    data = data.substr(start, end - start + 1);

    std::istringstream iss(data);
    std::ostringstream oss;
    std::string word;

    while (iss >> word) {
        if (oss.tellp() > 0)
            oss << ' ';
        oss << word;
    }

    data = oss.str();
}
