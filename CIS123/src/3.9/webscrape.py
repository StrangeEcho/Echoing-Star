import requests
from bs4 import BeautifulSoup

print("rubtho6330\n\n")

def readwebpage(page_number: str) -> requests.Response:
    url = f"https://quotes.toscrape.com/page/{page_number}"
    return requests.get(url)

def parsehtml(html: requests.Response) -> BeautifulSoup:
    return BeautifulSoup(html.content, "html.parser")

def outputquotes(parsed: BeautifulSoup) -> None:
    quotes = parsed.find_all("div", class_="quote")
    for quote in quotes:
        text = quote.find("span", class_="text").text
        author = quote.find("small", class_="author").text
        print(f"{text} - {author}")

page_number = input("Enter a page number to retrieve quotes from: ")
outputquotes(parsehtml(readwebpage(page_number)))