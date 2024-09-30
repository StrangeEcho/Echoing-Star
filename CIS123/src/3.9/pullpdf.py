import pdfplumber

print("rubtho6330")

def pullpdf(pdf: str) -> pdfplumber.PDF:
    return pdfplumber.open(pdf)

def writepdf(pdf: pdfplumber.PDF) -> None:
    f = open("rubtho6330_USCensus.txt", "w", encoding="utf-8")
    for page in pdf.pages:
        f.write(page.extract_text())
    f.close()
    
writepdf(pullpdf("./ext/USCensus.pdf"))