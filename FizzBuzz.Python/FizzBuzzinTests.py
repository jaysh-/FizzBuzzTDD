import FizzBuzzin as FB

Fizz = "Fizz"
Buzz = "Buzz"
FizzBuzz = "Fizz Buzz"
FizzBuzz1to32 = "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, " \
               "13, 14, Fizz Buzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, " \
               "Fizz, Buzz, 26, Fizz, 28, 29, Fizz Buzz, 31"

def NoFizzOrBuzz(n):
    result = FB.getNthFizzBuzz(2)
    assert(result == str(n))

def OneFizz(n):
    result = FB.getNthFizzBuzz(3)
    assert(result == Fizz)

def OneBuzz(n):
    result = FB.getNthFizzBuzz(n)
    assert(result == Buzz)

def OneFizzBuzz(n):
    result = FB.getNthFizzBuzz(n)
    assert(result == FizzBuzz)

def UpToAndIncluding31(n):
    actual = ""
    for i in range(1, n):
        actual += FB.getNthFizzBuzz(i) + ", "
    #Fence post
    actual += FB.getNthFizzBuzz(n)
    assert(actual == FizzBuzz1to32)

if (__name__ == '__main__'):
    NoFizzOrBuzz(2)
    OneFizz(3)
    OneBuzz(5)
    OneFizzBuzz(15)
    UpTo31(31)