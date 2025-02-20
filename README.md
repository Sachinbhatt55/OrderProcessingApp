# Order Processing Application

## Overview
This is a simple **ASP.NET Core MVC** application designed to calculate discounts for customer orders. The system allows customers to enter an order amount and select their customer type (either "New" or "Loyal"). If the customer is "Loyal" and the order amount is $100 or more, a 10% discount is applied; otherwise, no discount is applied. The calculated discount and the final order total are displayed on a results page.

### Business Requirements
- **Customer Types:**
  - **New**: No discount is applied.
  - **Loyal**: If the order amount is $100 or more, a **10% discount** is applied.
  
- **Discount Logic:**
  - If the **order amount is $100 or more** and the customer is **"Loyal"**, a **10% discount** is applied.
  - If the order is less than $100 or the customer is a **"New"** customer, **no discount** is applied.

## Features
- **Order Entry Form:** Customers can enter their order amount and select their customer type ("New" or "Loyal").
- **Discount Calculation:** Based on the input, the application calculates and displays the discount (if any) and the final order amount after applying the discount.
- **Results Page:** Shows the calculated discount and the final price to the customer.

## Project Structure
- **Controllers**: Contains the `OrderController` which handles the logic for processing orders.
- **Models**: Contains the `Order` class, which holds the order details (amount, customer type, discount, and final amount).
- **Views**: 
  - `Order/Index`: The form to enter the order details.
  - `Order/Result`: The page that shows the discount and the final amount after processing.
  
## Requirements
To run the project, you need:
- **.NET 8.0** (or later)
- **Visual Studio 2022** (or later) / **Visual Studio Code** with the **C# extension**
- **Git** for version control


