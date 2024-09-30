import pdfplumber

print("rubtho6330")

def open_pdf(pdf_name: str) -> pdfplumber.PDF:
    return pdfplumber.open(pdf_name)

def display_contents(pdf: pdfplumber.PDF) -> None:
    print("\n\n".join([page.extract_text() for page in pdf.pages]))
    
if __name__ == "__main__":
    display_contents(open_pdf("./ext/CodeExample.pdf"))