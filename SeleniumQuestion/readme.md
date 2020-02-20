# Selenium Question

You are given a login page to an online service. Your task is to validate whether the form works correctly.

Write a list of test cases that should check whether the given page works correctly. Write them as Pytest test methods (`test_`) in `test_class.py` class. Before each test, your class is called with the web_driver already pointing at the page being tested.

You can play with the fully working reference page [here](index.html), open this file locally with your browser.

You can use the following credentials to check the login process:

- Valid credentials: email: login@bjss.com, Password: hireme123!
- Invalid credentials: email: unknown@bjss.com, Password: password

Requirements:
-------------

1\. Check if the email and password fields are on the main screen of the application:

-   Email input has `id` equal to `email-input`;
-   Password input has `id` equal to `password-input`;
-   Login button has `id` equal to `login-button`.

2\. Check if the given valid credentials work:

-   Use credentials given in the description.
-   After a successful login attempt, a `div` with `class` equal to `message success` and containing a message: `Welcome to BJSS` is visible.

3\. Check if the given wrong credentials work:

-   Use credentials given in the description.
-   After an unsuccessful login attempt, a `div` with `class` equal to `message error` and containing a message `You shall not pass!` is visible.

4\. Check if the email validation is working:

-   Use email in an invalid form
-   After an unsuccessful login attempt, a `div` with `class` equal to `validation error` and containing a message `Enter a valid email` is visible.

5\. Check for empty credentials:

-   After an unsuccessful login attempt, a `div` with `class` equal to `validation error` and containing a message `Email is required` is visible.
-   After an unsuccessful login attempt, a `div` with `class` equal to `validation error` and containing a message `Password is required` is visible.

Assessment/Tools:
-----------------

-   The WebDriver that is provided (`web_driver`) in the fixture is already pointing to the page being tested.
-   Make sure you start your test case names with `test_`.

-   If the page being tested is misbehaving, at least one of your tests should fail.
-   Performance is not assessed; focus only on the correctness of the tests.
-   Tests may take a longer time than expected due to the browser running in the background.