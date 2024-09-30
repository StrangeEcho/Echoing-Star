print("rubtho6330")

def readfile(file: str) -> list[str]:
    """Read file and return sorted lines"""
    f = open(file, "r")
    lines = sorted([line.strip() for line in f.readlines()]) # Use of list comprehension to strip line breaks
    f.close()
    
    return lines

def writefile(*, file: str, lines: list[str]) -> None:
    """Write to specified file with information passed"""
    f = open(file, "w", encoding="utf-8")
    for line in lines:
        f.write(line + "\n")
    f.close()
    
def appendfile(file: str, line: str) -> None:
    """Append a passed line onto the file specified"""
    f = open(file, "a")
    f.write(line)
    f.close()
