def valid(sides):
    a,b,c = sorted(sides) # sorted side in order. c largest whilst a is the smallest
    return a > 0 and ( a + b >= c) # ensure it valid and that the side is above 0

def equilateral(sides):
    if not valid(sides):
        return False
    return len(set(sides)) == 1


def isosceles(sides):
    if not valid(sides):
        return False
    return len(set(sides)) <= 2

def scalene(sides):
    if not valid(sides):
        return False
    return len(set(sides)) == 3
