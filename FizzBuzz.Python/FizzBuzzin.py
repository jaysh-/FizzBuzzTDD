def getNthFizzBuzz(n):
    if isMultipleOfThree(n) and isMultipleOfFive(n):
        return "Fizz Buzz"
    elif isMultipleOfThree(n):
        return "Fizz"
    elif isMultipleOfFive(n):
        return "Buzz"
    return str(n)

def isMultipleOfThree(n):
    return n % 3 == 0

def isMultipleOfFive(n):
    return n % 5 == 0