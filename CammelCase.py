string = "my_first_string"
string = [item.capitalize() for item in string.split('_')] # Конструктор + трим строки
new_string = ''.join(string) # Объединение строки
print(new_string)
