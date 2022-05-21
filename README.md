# National Identity Card - Windows Forms Application
## An application to retrieve personal details of a Sri Lankan citizen from a given NIC number

Old NIC numbers having 10 characters. The first two digits represent the birth year (For 962311684V year is 1996). New NIC numbers having 12 characters. The first four digits represent the birth year (For 19962311684V year is 1996). The next three digits (231) represent birth month and day. It’s the number of total days from January 1st to the birthday. Also, these three digits represent the gender. If it is less than 500, the person is Male, otherwise the person is Female. For females, an additional 500 has been added to the number of days from January 1st to the birthday. The last character is the letter ‘V’ or ‘X’. ‘V’ is for persons who are eligible to vote. ‘X’ is for persons who are not eligible to vote.

The Implementation flows through 3 steps

### Step 1 - NIC Text Box
A ‘Windows Forms Control Library’ is created implementing a Custom Control Textbox which allows user to enter numbers and uppercase letters ‘V’ or ‘X’ only. It further allows the user to use the ‘Backspace’ key. It does not allow any other characters to enter. It has some difference in appearance to be identified separately. The repository: https://github.com/pabasar/NICTextBox

### Step 2 - NIC Operations Class Library
‘Class Library’ is created which having all the functions necessary to retrieve a person’s,  
•	Gender
•	Date of Birth in format of 1987.07.25
•	Vote eligibility

It is implemented to support old (962311684V) and new (19962311684V) NIC number types. Consider the number of days in February as 29. It is built as a Dynamic Link Library (DLL) file, to be used in the main application. The repository: https://github.com/pabasar/NICLibrary

### Step 3 - NIC Personal Details Application
A ‘Windows Forms Application’ is created, making use of the created custom control textbox in Step 1 and the DLL file in Step 2, applying OOP concepts. This application is to display personal information as mentioned in Step 2. Consider the following functionalities.
•	Initially, ‘Next Person’ button is disabled and cursor is focused in input text box.
•	For the input textbox, created custom control textbox is used with relevant restrictions.
•	User should enter the NIC number and then pressing ‘Enter’ key should display the details in read-only text boxes.
•	Then ‘Next Person’ button is enabled and focused.
•	When clicking on ‘Next Person’ button or pressing ‘Enter’ key makes all text boxes empty and switch to next person and allow user to enter the next person’s NIC number.
•	Such a way user is able to retrieve personal information of any number of persons, entering NIC numbers one by one and pressing ‘Enter’ key.
•	If user has entered an NIC number which not having number of characters according to new or old NIC number format, then system informs the user as ‘Invalid NIC!’ via a MessageBox.

![image](https://user-images.githubusercontent.com/49782156/169662420-888ca649-6272-4ebb-8b78-22ccfa9eba13.png)
