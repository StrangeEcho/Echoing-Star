import PAFunctions
import requests
from bs4 import BeautifulSoup


def readwebpage() -> requests.Response:
    url = f"https://quotes.toscrape.com/page/2"
    return requests.get(url)

def parsehtml(html: requests.Response) -> BeautifulSoup:
    return BeautifulSoup(html.content, "html.parser")

def outputquotes(parsed: BeautifulSoup) -> None:
    quotes = parsed.find_all("div", class_="quote")
    for quote in quotes:
        text = quote.find("span", class_="text").text
        author = quote.find("small", class_="author").text
        print(f"{text} - {author}")

PAFunctions.goodbye_world()
PAFunctions.check_range()
PAFunctions.days_until_graduation()

outputquotes(parsehtml(readwebpage()))