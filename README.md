# CSharp_Using-Classes-And-Objects

SlayTeam

# Exercise Instructions
9-1
--
Create an application named TestSoccerPlayer that instantiates and displays a SoccerPlayer object. The SoccerPlayer class contains properties that hold a player’s name (a string), jersey number (an integer), goals scored (an integer), and assists (an integer).

9-2
--
Create an application named TestClassifiedAd that instantiates and displays at least two ClassifiedAd objects. A ClassifiedAd has fields for a category (for example, Used Cars), a number of words, and a price. Include properties that contain get and set accessors for the category and number of words, but only a get accessor for the price. The price is calculated at nine cents per word.

9-3
--
Create an application named SalesTransactionDemo that declares several SalesTransaction objects and displays their values and their sum. The SalesTransaction class contains fields for a salesperson name, sales amount, and commission and a readonly field that stores the commission rate. Include three constructors for the class. One constructor accepts values for the name, sales amount, and rate, and when the sales value is set, the constructor computes the commission as sales value times commission rate. The second constructor accepts a name and sales amount, but sets the commission rate to 0. The third constructor accepts a name and sets all the other fields to 0. An overloaded + operator adds the sales values for two SalesTransaction objects.

9-4
--
Create a program named PaintingDemo that instantiates an array of eight Room objects and demonstrates the Room methods. The Room constructor requires parameters for length, width, and height fields; use a variety of values when constructing the objects. The Room class also contains a field for wall area of the Room and number of gallons of paint needed to paint the room. Both of these values are computed by calling private methods. Include read-only properties to get a Room’s values. A room is assumed to have four walls, and you do not need to allow for windows and doors, and you do not need to allow for painting the ceiling. A room requires one gallon of paint for every 350 square feet (plus an extra gallon for any square feet greater than 350). In other words, a 12 × 10 room with 9-foot ceilings has 396 square feet of wall space, and so requires two gallons of paint.

9-5
--
Create an application named CarDemo that declares at least two Car objects and demonstrates how they can be incremented using an overloaded ++ operator. Create a Car class that contains a model and a value for miles per gallon. Include two overloaded constructors. One accepts parameters for the model and miles per gallon; the other accepts a model and sets the miles per gallon to 20. Overload a ++ operator that increases the miles per gallon value by 1. The CarDemo application creates at least one Car using each constructor and displays the Car values both before and after incrementation.

9-6
--
A. Create a program named SalesTaxDemo that declares an array of 10 Sale objects. Prompt the user for data for each object and display the 10 objects. Data fields for Sale objects include an inventory number, amount of the sale, and tax owed. Include a property with get and set accessors for the first two data fields, but make the tax owed a read-only property. The tax should be calculated whenever the amount of the sale is set. Assume that the tax rate is 8 percent for the first $100 and 6 percent for any amount greater than $100.

B. Create a program named SalesTaxDemo2 so that after the 10 Sale objects are displayed, they are sorted in order by the amount of tax owed and displayed again. Modify the Sale class so its objects are comparable to each other based on tax owed.

9-7
--
Create an application named ShirtDemo that declares several Shirt objects and includes a display method to which you can pass different numbers of Shirt objects in successive method calls. The Shirt class contains auto-implemented properties for a material, color, and size.

9-8
--
Create a program named ConferencesDemo for a hotel that hosts business conferences. Allows a user to enter data about five Conference objects and then displays them in order of attendance from smallest to largest. The Conference class contains fields for the Conference group name, starting date (as a string), and number of attendees. Include properties for each field. Also, include an IComparable.CompareTo() method so that Conference objects can be sorted.

9-9
--
A. Create a program named RelativesList that declares an array of at least 12 relative objects and prompts the user to enter data about them. The Relative class includes auto-implemented properties for the Relative’s name, relationship to you (for example, aunt), and three integers that together represent the Relative’s birthday—month, day, and year. Display the Relative objects in alphabetical order by first name.

B. Create a RelativesBirthday program that modifies the RelativesList program so that after the alphabetical list is displayed, the program prompts the user for a specific Relative’s name and the program returns the Relative’s relationship and birthday. Display an appropriate message if the relative requested by the user is not found.

9-10
--
A. Write a program named DemoJobs for Harold’s Home Services. The program should instantiate several Job objects and demonstrate their methods. The Job class contains four data fields—description (for example, “wash windows”), time in hours to complete (for example, 3.5), per-hour rate charged (for example, $25.00), and total fee (hourly rate times hours). Include properties to get and set each field except the total fee—that field will be read-only, and its value is calculated each time either the hourly fee or the number of hours is set. Overload the + operator so that two Jobs can be added. The sum of two Jobs is a new Job containing the descriptions of both original Jobs (joined by and), the sum of the time in hours for the original Jobs, and the average of the hourly rate for the original Jobs.

B. Harold has realized that his method for computing the fee for combined jobs is not fair. For example, consider the following:

- His fee for painting a house is $100 per hour. If a job takes 10 hours, he earns $1000.

- His fee for dog walking is $10 per hour. If a job takes 1 hour, he earns $10.

- If he combines the two jobs and works a total of 11 hours, he earns only the average rate of $55 per hour, or $605.

Devise an improved, weighted method for calculating Harold’s fees for combined Jobs and include it in the overloaded operator+() method. Write a program named DemoJobs2 that demonstrates all the methods in the class work correctly.

9-11
--
A. Write a FractionDemo program that instantiates several Fraction objects and demonstrates that their methods work correctly. Create a Fraction class with fields that hold a whole number, a numerator, and a denominator. In addition:

- Create properties for each field. The set accessor for the denominator should not allow a 0 value; the value defaults to 1.

- Add three constructors. One takes three parameters for a whole number, numerator, and denominator. Another accepts two parameters for the numerator and denominator; when this constructor is used, the whole number value is 0. The last constructor is parameterless; it sets the whole number and numerator to 0 and the denominator to 1. (After construction, Fractions do not have to be reduced to proper form. For example, even though 3/9 could be reduced to 1/3, your constructors do not have to perform this task.)

- Add a Reduce() method that reduces a Fraction if it is in improper form. For example, 2/4 should be reduced to 1/2.

- Add an operator+() method that adds two Fractions. To add two fractions, first eliminate any whole number part of the value. For example, 2 1/4 becomes 9/4 and 1 3/5 becomes 8/5. Find a common denominator and convert the fractions to it. For example, when adding 9/4 and 8/5, you can convert them to 45/20 and 32/20. Then you can add the numerators, giving 77/20. Finally, call the Reduce() method to reduce the result, restoring any whole number value so the fractional part of the number is less than 1. For example, 77/20 becomes 3 17/20.

- Include a function that returns a string that contains a Fraction in the usual display format—the whole number, a space, the numerator, a slash (/), and a denominator. When the whole number is 0, just the Fraction part of the value should be displayed (for example, 1/2 instead of 0 1/2). If the numerator is 0, just the whole number should be displayed (for example, 2 instead of 2 0/3).

B. Add an operator*() method to the Fraction class created in Exercise 11a so that it correctly multiplies two Fractions. The result should be in proper, reduced format. Demonstrate that the method works correctly in a program named FractionDemo2.

C. Write a program named FractionDemo3 that includes an array of four Fractions. Prompt the user for values for each. Display every possible combination of addition results and every possible combination of multiplication results for each Fraction pair (that is, each type will have 16 results).

# Case Problems

1. In previous chapters, you have created programs for the Greenville Idol competition. Now create a Contestant class with the following characteristics:

- The Contestant class contains public static arrays that hold talent codes and descriptions. Recall that the talent categories are Singing, Dancing, Musical instrument, and Other.

- The class contains an auto-implemented property that holds a contestant’s name.

- The class contains fields for a talent code and description. The set accessor for the code assigns a code only if it is valid. Otherwise, it assigns I for Invalid. The talent description is a read-only property that is assigned a value when the code is set.

Modify the GreenvilleRevenue program so that it uses the Contestant class and performs the following tasks:

- The program prompts the user for the number of contestants in this year’s competition; the number must be between 0 and 30. The program continues to prompt the user until a valid value is entered.

- The expected revenue is calculated and displayed. The revenue is $25 per contestant.

- The program prompts the user for names and talent codes for each contestant entered. Along with the prompt for a talent code, display a list of the valid categories.

- After data entry is complete, the program displays the valid talent categories and then continuously prompts the user for talent codes and displays the names of all contestants in the category. Appropriate messages are displayed if the entered code is not a character or a valid code.

2. In previous chapters, you have created programs for Marshall’s Murals. Now create a Mural class with the following characteristics:

- The Mural class contains public static arrays that hold mural codes and descriptions. Recall that the mural categories are Landscape, Seascape, Abstract, Children’s, and Other.

- The class contains an auto-implemented property that holds a mural customer’s name.

- The class contains fields for a mural code and description. The set accessor for the code assigns a code only if it is valid. Otherwise, it assigns I for Invalid. The mural description is a read-only property that is assigned a value when the code is set.

Modify the MarshallsRevenue program so that it uses the Mural class and performs the following tasks:

- The program prompts the user for the month, the number of interior murals scheduled, and the number of exterior murals scheduled. In each case, the program continues to prompt the user until valid entries are made.

- The expected revenue is calculated and displayed. Recall that exterior murals cannot be painted in December through February. Also recall that exterior murals are $750 in all months except April, May, September, and October, when they are $699. Interior murals are $500 except during July and August, when they are $450.

- The program prompts the user for names and mural codes for interior and exterior murals. Along with the prompt for a mural code, display a list of the valid categories.

- After data entry is complete, the program displays the valid mural categories and then continuously prompts the user for codes and displays the names of all customers ordering murals in the category. Appropriate messages are displayed if the entered code is not a character or a valid code.
