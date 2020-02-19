import os

import pytest
from selenium import webdriver
from chromedriver_py import binary_path


@pytest.fixture
def before_each():
    web_driver = webdriver.Chrome(executable_path=binary_path)
    file_path = os.path.abspath(os.path.join(os.getcwd(), os.pardir, "index.html"))
    web_driver.get(file_path)
    return web_driver


class TestClass:
    def test_page(self, before_each):
        web_driver = before_each
        assert "Test me" in web_driver.title
