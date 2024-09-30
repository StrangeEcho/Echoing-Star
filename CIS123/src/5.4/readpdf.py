import pdfplumber

pdfToString = ""
pdf_path = "./ext/SmallPDF.pdf"

with pdfplumber.open(pdf_path) as pdf:
    for page in pdf.pages:
        string = page.extract_text()
        pdfToString += string

f = open("./output/Small.txt", "w")
f.write(pdfToString)
f.close()