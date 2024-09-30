print("rubtho6330")

def readfile():
    names = []

    fopen = open("./names.txt", "r")
    for line in fopen:
        line = line.replace ("\n", "")
        names.append(line)
    fopen.close()
    return names

def writefile(names):
    fopen = open("./sorted_names.txt", "w")
    for line in names:
        fopen.write(line)
    fopen.close()

def appendfile(line):
    fopen = open("./sorted_names.txt", "a")
    fopen.write(line)
    fopen.close()

writefile(sorted(readfile()))
appendfile("End of file")
