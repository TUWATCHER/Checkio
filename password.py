s = "A1213pokl"
isLen = 0
isLower = 0
isUpper = 0
isDigit = 0
if len(s) >= 10:
    isLen = 1

for i in range(len(s)):
    if s[i].isupper():
        isUpper = 1
        # print("True")


for i in range(len(s)):
    if s[i].islower():
        isLower = 1
        # print("True")

for i in range(len(s)):
    if s[i].isdigit():
        isDigit = 1
        # print("True")

if isLen == 1 and isDigit == 1 and isUpper == 1 and isLower == 1:
    print("True")

else:
    print("False")
