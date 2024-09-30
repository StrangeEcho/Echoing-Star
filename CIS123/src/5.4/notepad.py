import subprocess

file_object = open("notepad.txt", "a")
file_object.write("hello\n")
file_object.write("This is a new line\n")
file_object.close()

p = subprocess.Popen("notepad notepad.txt")