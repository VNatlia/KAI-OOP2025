#pragma once

// ��������� ��� �������� ������
class ICleanable {
public:
    virtual void CleanSpaces() = 0;
    virtual ~ICleanable() = default;
};
