from openpyxl import Workbook
import datetime

book = Workbook()
sheet = book.active

sheet['A1'] = "rubtho6330"

sheet['A2'] = 25
sheet['A3'] = 45
sheet['A4'] = "=A2+A3"

now = datetime.datetime.now()
sheet['A5'] = now

book.save("FirstExcel.xlsx")
