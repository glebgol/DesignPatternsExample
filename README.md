# OnlineShop
The project  `Online Shop` 

Adding products to the shoppint cart, paying for the cart, canceling the order.

Using Design Patterns:

1. `Abstract Factory` - IShopFactory
2. `State` - Order state (In shopping cart, completed..)
3. `Strategy` - Payment Strategies (Visa, MasterCard, BelKart)
4. `Template Method` - Order Payment (BelSystem, ForeignSystem):
    - Calculate price before discount
    - Discount calculation
    - Bonus accrual
5. `Command` - Delete order

