Developers : Hai Do, Brijesh Patel.  
Description : This project is to make desktop application using C# (WindowForm) to create a POS system for a technical store.  

Application details: 

## POS System
Start Project inside POSApp.  
### Login Credentials: 
  - 1> UserName: haid Password: haid 
  - 2> UserName: kara Password: kara
### Features
* Scanning Product : Type barcode in textbox and press scan button in left side panel.
* Scanning Customer: Type Customer number in textbox and press scan button in left side panel - The customer code is from c500 to c505.
* Search Product : Click on search product button to see available product in store Apply different filters like keyword, brands or/and category to filter product you need
* Finalize Order : Click finalize order to complete order payment 1> Type money paid by customer in appropriate payment type textbox 2> type number customer wants to redeem, if customer have. 3> Apply extra discount in discount textbox. 4> customer can split payment between cash and card 5> click on Abort Transaction to cancel order
* Print Last Order: press button to print last completed order
* Print Detailed Order: shows all the transaction done for today
* Day End: type the amount you started with and money you counted in till Day end report will variance if till need to be balanced.
* Recommendation :
  * if there is no customer code scanned --> show two available random products in store
  * if customer code is scanned , but customer has not bought any product before --> show two available randow products in store
  * if customer code is scanned, and customer has bought one to many products before --> show the latest product that they bought and one random product in store
