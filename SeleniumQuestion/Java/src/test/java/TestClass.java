import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

import java.nio.file.Path;
import java.nio.file.Paths;

public class TestClass {

    public WebDriver webdriver;

    @Before
    public void before(){
        Path pathToChromeDriver = Paths.get("bin/chromedriver80.exe");
        System.setProperty("webdriver.chrome.driver", pathToChromeDriver.toAbsolutePath().toString());
        webdriver = new ChromeDriver();
        Path pathToIndexFile = Paths.get("../index.html");
        webdriver.get(pathToIndexFile.toAbsolutePath().toString());
    }

    @After
    public void after(){
        webdriver.quit();
    }

    @Test
    public void test_page(){
        assert webdriver.getTitle().equals("Test me");
    }
}
