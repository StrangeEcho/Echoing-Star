import requests
from bs4 import BeautifulSoup

print("rubtho6330")

def readwebpage(url: str) -> requests.Response:
    return requests.get(url)

def parsehtml(html: requests.Response) -> BeautifulSoup:
    return BeautifulSoup(html.content, "html.parser")

def outputquotes(parsed: BeautifulSoup) -> None:
    quotes = parsed.find_all("div", class_="quote")
    for quote in quotes:
        text = quote.find("span", class_="text").text
        author = quote.find("small", class_="author").text
        print(f"{text} - {author}")

url = "http://quotes.toscrape.com"
outputquotes(parsehtml(readwebpage(url)))