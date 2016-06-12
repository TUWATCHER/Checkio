string = "my_first_string"
string = [item.capitalize() for item in string.split('_')]
new_string = ''.join(string)
print(new_string)
