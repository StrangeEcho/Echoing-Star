from openpyxl import Workbook

book = Workbook()
sheet = book.active

data = [
    ["A", 100, 1.0],
    ["B", 200, 2.0],
    ["C", 300, 3.0],
    ["D", 400, 4.0],
    ["E", 500, 5.0],
    ["F", 600, 6.0],
    ["G", 700, 7.0],
    ["H", 800, 8.0]
]

for row in data:
    sheet.append(row)

book.save("SecondBook.xlsx")