# Selenium Webdriver C#
<p>
Selenium supports many language bindings like Java, C#, Python,Ruby, JavaScript and so on. This project will help you to get know the  Selenium Webdriver C#  which will cover real time scenarios which we handle in day to day activity.
</p>



#What is Selenium
Selenium is a portable software testing suite for web applications. Primarily, it is for automating web applications for testing purpose, but it certainly not limited to just that. Selenium is open source. Selenium is highly flexible. There are many ways you can add functionality to both Selenium test scripts and Selenium’s framework to customize your test automation i.e. We can modify the built-in selenium functions based on our requirement. This is perhaps Selenium’s greatest strength when compared with other automation tools. Selenium is a set of different software tools each with a different approach to supporting test automation. It has 4 components.
<ui>
  <li>Selenium Integrated Development Environment (IDE).</li>
   <li>Selenium Remote Control (RC).</li>
   <li>Selenium WebDriver.</li>
   <li>Selenium Grid.</li>
  </ui>
  
  # Nuget packages  you have to install 
<img src="https://github.com/T2-Business/T2.SeleniumWithCSharp/blob/main/selenium.png"/>


# WebElements Commands in Selenium WebDriver with C Sharp  Commands


<table style ="background-color: dodgerblue;">
  <tr>
   <td>
Syntax	   
</td>
   <td>
     Description
</td>
  </tr> 
    <tr>    
      <td> Click()  </td> 
      <td> This method is used to click on webelement.	void IWebElement.Click()
	 </td> 
   </tr>
 <tr>    
      <td> SendKeys(String value)  </td> 
      <td> This method is used to send values to webelement.	void IWebElement.SendKeys(String value)
where value is the value to be entered in webelement.   </td> 
</tr>
 <tr>    
      <td>Close()	   </td> 
      <td>  This method closes the browser window that the driver has focus of void IWebDriver.Close()  </td> 
</tr>
 <tr>    
      <td>   Dispose() </td> 
      <td> This method closes all browser windows and safely ends the session
void IWebDriver.Dispose()  </td> 
</tr>
 <tr>    
      <td> Quit()  </td> 
      <td> his method internally calls Dispose() method	void IWebDriver.Quit()  </td> 
</tr>
 <tr>    
      <td> FindElement()  </td> 
      <td> This method is used to Find first WebElement in webpage using some properties like Xpath, ClassName, CssSelector, Id, etc..	 IWebElement ISearchContext.FindElement(By.Xpath(xpathexpression))
Return type of FindElement method is IWebElement  </td> 
</tr>
   <tr>    
      <td> SwitchTo()	   </td> 
      <td>  This method is used to switch to Frames, Windows, Alert, ActiveElement	ITargetLocator IWebDriver.SwitchTo()
return type is the target locator. </td> 
</tr>
  <tr>    
      <td>  Manage()  </td> 
      <td>  this method is used to perform windows based operations like maximize, minimize etc..	 IOptions IWebDriver.Manage()
return type is options  </td> 
</tr>
  <tr>    
      <td>  Submit()  </td> 
      <td> this method will submit the form and will send to server. I personally don’t use this.	driver.FindElement(By.Id(“”)).Submit();   </td> 
</tr>
  <tr>    
      <td>  GetAttribute()	  </td> 
      <td> This method will fetch attribute from WebElement and will return as String	String
data=driver.FindElement(By.Id(“”)).GetAttribute(“Attribute Name”);   </td> 
</tr>
  <tr>    
      <td>  GetCssValue()  </td> 
      <td> This method will return css attribute of WebElement which you will pass and will return String value	String data=driver.FindElement(By.Id(“”)).GetCssValue(“CSS Attribute”);roperties	Description	Syntax    </td> 
</tr>
   <tr>    
      <td> Text   </td> 
      <td>   > Capture the text from WebElement and return String	String data=driver.FindElement(By.Id(“”)).Text; </td> 
</tr>
 <tr>    
      <td> Selected    </td> 
      <td> 	This will get whether element is Selected or not and this will be only applicable for input type like Radio button, Checkbox etc	Boolean data=driver.FindElement(By.Id(“”)).Selected  </td> 
</tr>
 <tr>    
      <td> Enabled    </td> 
      <td>  This will check whether element is enabled or not and return Boolean	Boolean data=driver.FindElement(By.Id(“”)).Enabled; </td> 
</tr>
 <tr>    
      <td> Displayed   </td> 
      <td> This will check of element presence in DOM and will return Boolean	Boolean data=driver.FindElement(By.Id(“”)).Displayed;   </td> 
</tr>
 <tr>    
      <td>   TagName </td> 
      <td>    	It finds the TagName of element and return as a String	String data=driver.FindElement(By.Id(“”)).TagName;</td> 
</tr>
 <tr>    
      <td>  Size  </td> 
      <td>  	It returns the Size of WebElement like Widht and Height	int height=driver.FindElement(By.Id(“”)).Size.Height;  </td> 
</tr>
<tr>    
      <td>   width   </td> 
      <td> int width = driver.FindElement(By.Id(“”)).Size.Width;   </td> 
</tr>
<tr>    
      <td> Location   </td> 
      <td>   It help us to find coordinates  of WebElement	int x = driver.FindElement(By.Id(“”)).Location.X; </td> 
</tr>
 <tr>    
      <td>    int y  </td> 
      <td>  int y = driver.FindElement(By.Id(“”)).Location.Y  </td> 
</tr>
</table>
 
