bool IsLeapYear(int year)
{
    if (year % 4 != 0) return false;
    if (year % 100 != 0) return true;
    if (year % 400 != 0) return false;
    return true;
}


// One-line version

bool IsLeapYear(int year) => year % 4 != 0 ? false : year % 100 != 0 ? true : year % 400 != 0 ? false : true;