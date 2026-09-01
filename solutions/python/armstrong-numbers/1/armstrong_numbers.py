def is_armstrong_number(number):
    digits = str(number)
    length = len(digits)
    total = 0
    for i in digits:
        total += int(i) ** length
    return total == number
        
