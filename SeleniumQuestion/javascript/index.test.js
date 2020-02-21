const sw = require("selenium-webdriver")
const chrome = require('selenium-webdriver/chrome')
const chromedriver = require('chromedriver')
const path = require('path');

chrome.setDefaultService(new chrome.ServiceBuilder(chromedriver.path).build());
const options = new chrome.Options();
const file = path.join(__dirname, '..', 'index.html');
const webdriver = new sw.Builder().forBrowser("chrome").setChromeOptions(options).build();

beforeEach(() => {
  return webdriver.get(file);
});

afterAll(() => {
  webdriver.quit();
});

test('page test', async () => {    
  expect(await webdriver.getTitle()).toBe("Test me");
});