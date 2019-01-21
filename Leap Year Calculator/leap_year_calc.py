def is_leap_year(year):
    if year % 4 != 0 : return False
    if year % 100 != 0 : return True
    if year % 400 != 0 : return False
    return True


# One-line version

def is_leap_year(year):
    return False if year % 4 != 0 else True if year % 100 != 0 else False if year % 400 != 0 else True