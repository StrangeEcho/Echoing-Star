import pdfplumber


print("rubtho6330")

def pullpdf(pdf: str):
    pull = pdfplumber.open(pdf)
    return pull

pdf = pullpdf("./SimplePDF.pdf")
page = pdf.pages[0]
print(page.extract_text())